using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraFactura
    {
        private const int TipoComprobanteFacturaC = 11;
        private const int ConceptoProductos = 1;
        private const int TipoDocumentoDni = 96;
        private const int TipoDocumentoConsumidorFinal = 99;
        private const int CondicionFiscalConsumidorFinal = 3;
        private const int AlicuotaIvaCero = 3;
        private const int PuntoVentaPrueba = 1;
        private const int MetodoPagoOtro = 8;
        private static readonly HttpClient HttpClient = new();

        private static ControladoraFactura? instancia;

        private ControladoraFactura()
        {
        }

        public static ControladoraFactura Instancia
        {
            get
            {
                instancia ??= new ControladoraFactura();
                return instancia;
            }
        }

        public async Task<byte[]> GenerarFacturaCPruebaPdfAsync(Venta venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            if (venta.Detalles == null || venta.Detalles.Count == 0)
                throw new InvalidOperationException("La venta no tiene productos para facturar.");

            string apiUrl = EnvironmentLoader
                .GetRequiredVariable("FACTURACION_API_URL") //busca la variables del entorno previamente cargado 
                .TrimEnd('/');
            string apiKey = EnvironmentLoader.GetRequiredVariable("FACTURACION_API_KEY");

            object requestBody = ConstruirRequestComprobante(venta); //construimos la request con los datos de la venta
            string json = JsonSerializer.Serialize(requestBody); //convertimos el objeto a string en formato json

            using HttpRequestMessage request = new( //ACA HACE LA PETICION HTTP A LA API DE FACTURACION
                HttpMethod.Post,
                $"{apiUrl}/api/v2/documentos/comprobante" //URL + ENDPOINT 
            );
            //Estas son las cabeceras de la peticion. REQUEST
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/pdf")); //lo q aceptamos 
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            using HttpResponseMessage response = await HttpClient.SendAsync(request); //ENVIOOOOOOOO
            byte[] content = await response.Content.ReadAsByteArrayAsync();

            //Valida si hay error
            if (!response.IsSuccessStatusCode)
            {
                string detalle = ObtenerDetalleError(response, content);
                throw new InvalidOperationException(detalle);
            }

            if (content.Length == 0)
                throw new InvalidOperationException("La API devolvió un archivo vacío.");

            string? mediaType = response.Content.Headers.ContentType?.MediaType;
            if (!string.Equals(mediaType, "application/pdf", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    "La API no devolvió un PDF. Tipo recibido: " +
                    (string.IsNullOrWhiteSpace(mediaType) ? "desconocido" : mediaType)
                );
            }

            return content;
        }

        private static object ConstruirRequestComprobante(Venta venta)
        {
            DateTime fechaComprobante = venta.FechaVenta == default
                ? DateTime.Today
                : venta.FechaVenta;
            decimal total = RedondearImporte(venta.MontoTotal);
            long numeroDocumento = ObtenerNumeroDocumento(venta.Cliente?.NumeroDocumento);
            int tipoDocumento = numeroDocumento > 0
                ? TipoDocumentoDni
                : TipoDocumentoConsumidorFinal;

            return new
            {
                data = new
                {
                    comprobante = new
                    {
                        cae = GenerarCaePrueba(venta),
                        fecha_vencimiento_cae = FormatearFecha(fechaComprobante.AddDays(10)),
                        fecha_comprobante = FormatearFecha(fechaComprobante),
                        tipo_comprobante = TipoComprobanteFacturaC,
                        punto_venta = PuntoVentaPrueba,
                        numero_comprobante = venta.NumeroVenta > 0
                            ? venta.NumeroVenta
                            : venta.VentaId,
                        concepto = ConceptoProductos,
                        tipo_documento = tipoDocumento,
                        numero_documento = numeroDocumento,
                        moneda_id = "PES",
                        cotizacion = 1,
                        importe_total = total,
                        importe_no_gravado = 0,
                        importe_neto = total,
                        importe_exento = 0,
                        importe_tributos = 0,
                        importe_iva = 0,
                        alicuotas_iva = new[]
                        {
                            new
                            {
                                id = AlicuotaIvaCero,
                                base_imponible = total,
                                importe = 0
                            }
                        }
                    },
                    metadatos = new
                    {
                        condicion_fiscal_cliente = CondicionFiscalConsumidorFinal,
                        nombre_o_razon_social_cliente = ValorOPrueba(
                            venta.Cliente?.Nombre,
                            "Cliente de prueba"
                        ),
                        domicilio_cliente = ValorOPrueba(
                            venta.Cliente?.Domicilio,
                            "Domicilio de prueba 123"
                        ),
                        telefono_cliente = ValorOPrueba(
                            venta.Cliente?.Telefono,
                            "+54 11 5555-0000"
                        ),
                        email_cliente = ValorOEmailPrueba(venta.Cliente?.Email),
                        metodo_pago = MapearMetodoPago(venta.MetodoPago),
                        total_oini = 0
                    },
                    items = ConstruirItems(venta),
                    tamano_papel = "a4"
                }
            };
        }

        private static object[] ConstruirItems(Venta venta)
        {
            List<DetalleVenta> detalles = venta.Detalles
                .Where(d => d.Cantidad > 0)
                .ToList();

            decimal subtotalDetalles = detalles.Sum(d => RedondearImporte(d.Subtotal));
            decimal totalVenta = RedondearImporte(venta.MontoTotal);
            decimal factorDescuento = subtotalDetalles > 0
                ? totalVenta / subtotalDetalles
                : 1;

            List<object> items = new();
            decimal acumulado = 0;

            for (int i = 0; i < detalles.Count; i++)
            {
                DetalleVenta detalle = detalles[i];
                decimal subtotalItem = i == detalles.Count - 1
                    ? totalVenta - acumulado
                    : RedondearImporte(detalle.Subtotal * factorDescuento);
                acumulado += subtotalItem;

                decimal precioUnitario = RedondearImporte(subtotalItem / detalle.Cantidad);
                string id = !string.IsNullOrWhiteSpace(detalle.Producto?.Codigo)
                    ? detalle.Producto.Codigo
                    : detalle.ProductoId.ToString(CultureInfo.InvariantCulture);
                string descripcion = ObtenerDescripcionDetalle(detalle);

                items.Add(new
                {
                    id,
                    descripcion,
                    precio_unitario = precioUnitario,
                    cantidad = detalle.Cantidad,
                    alicuotas_iva = AlicuotaIvaCero.ToString(CultureInfo.InvariantCulture),
                    subtotal = subtotalItem
                });
            }

            return items.ToArray();
        }

        private static string GenerarCaePrueba(Venta venta)
        {
            DateTime fechaBase = venta.FechaVenta == default
                ? DateTime.Today
                : venta.FechaVenta;
            long fecha = long.Parse(
                fechaBase.ToString("yyyyMMdd", CultureInfo.InvariantCulture),
                CultureInfo.InvariantCulture
            );
            long semilla = Math.Abs(
                venta.VentaId * 1_000_003L +
                venta.NumeroVenta * 10_007L +
                fecha
            );
            long cae = 70000000000000L + semilla % 9999999999999L;
            return cae.ToString("00000000000000", CultureInfo.InvariantCulture);
        }

        private static long ObtenerNumeroDocumento(string? numeroDocumento)
        {
            if (string.IsNullOrWhiteSpace(numeroDocumento))
                return 0;

            string soloDigitos = new(numeroDocumento.Where(char.IsDigit).ToArray());

            if (long.TryParse(soloDigitos, out long resultado) && resultado > 0)
                return resultado;

            return 0;
        }

        private static int MapearMetodoPago(MetodoPago? metodoPago)
        {
            if (metodoPago?.EsCuentaCorriente == true)
                return 5;

            string nombre = metodoPago?.Nombre?.Trim().ToLowerInvariant() ?? string.Empty;

            if (nombre.Contains("contado") || nombre.Contains("efectivo"))
                return 1;

            if (nombre.Contains("debito") || nombre.Contains("débito"))
                return 2;

            if (nombre.Contains("credito") || nombre.Contains("crédito"))
                return 3;

            if (nombre.Contains("cheque"))
                return 4;

            if (nombre.Contains("ticket"))
                return 6;

            if (nombre.Contains("transfer"))
                return 7;

            return MetodoPagoOtro;
        }

        private static decimal RedondearImporte(decimal importe)
        {
            return Math.Round(importe, 2, MidpointRounding.AwayFromZero);
        }

        private static string FormatearFecha(DateTime fecha)
        {
            return fecha.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
        }

        private static string ValorOPrueba(string? valor, string valorPrueba)
        {
            return string.IsNullOrWhiteSpace(valor) ? valorPrueba : valor.Trim();
        }

        private static string ValorOEmailPrueba(string? email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
                return "cliente.prueba@example.com";

            return email.Trim();
        }

        private static string ObtenerDetalleError(
            HttpResponseMessage response,
            byte[] content
        )
        {
            string cuerpo = content.Length == 0
                ? string.Empty
                : Encoding.UTF8.GetString(content);
            string detalle = ExtraerDetalleError(cuerpo);
            string status = $"{(int)response.StatusCode} {response.ReasonPhrase}".Trim();

            return string.IsNullOrWhiteSpace(detalle)
                ? $"La API de facturación respondió {status}."
                : $"La API de facturación respondió {status}: {detalle}";
        }

        private static string ObtenerDescripcionDetalle(DetalleVenta detalle)
        {
            if (!string.IsNullOrWhiteSpace(detalle.Producto?.Nombre))
                return detalle.Producto.Nombre.Trim();

            if (!string.IsNullOrWhiteSpace(detalle.ProductoNombre))
                return detalle.ProductoNombre.Trim();

            if (!string.IsNullOrWhiteSpace(detalle.Producto?.Descripcion))
                return detalle.Producto.Descripcion.Trim();

            return $"Producto {detalle.ProductoId}";
        }

        private static string ExtraerDetalleError(string cuerpo)
        {
            if (string.IsNullOrWhiteSpace(cuerpo))
                return string.Empty;

            try
            {
                using JsonDocument document = JsonDocument.Parse(cuerpo);
                JsonElement root = document.RootElement;

                if (root.TryGetProperty("detail", out JsonElement detail))
                    return detail.GetString() ?? string.Empty;

                if (root.TryGetProperty("title", out JsonElement title))
                    return title.GetString() ?? string.Empty;

                if (root.TryGetProperty("message", out JsonElement message))
                    return message.GetString() ?? string.Empty;
            }
            catch (JsonException)
            {
            }

            return cuerpo.Length <= 500 ? cuerpo : cuerpo[..500];
        }
    }
}
