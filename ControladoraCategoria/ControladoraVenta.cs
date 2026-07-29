using Entidades;
using Modelo;
using Entidades.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVenta
    {
        private RepositorioVenta repositorio = new RepositorioVenta();

        private static ControladoraVenta instancia;

        private ControladoraVenta()
        {

        }
        public static ControladoraVenta Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraVenta();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }
        public int ObtenerProximoNumeroVenta()
        {
            try
            {
                return repositorio.ObtenerProximoNumeroVenta();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ControladoraVenta.ObtenerProximoNumeroVenta(): " + ex.Message);
            }
        }

        public IReadOnlyCollection<VentaResumenDTO> ListarVentasResumen()
        {
            try
            {
                return repositorio.ListarVentasResumen();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ControladoraVenta.ListarVentasResumen(): " + ex.Message);
            }
        }

        public Venta? ObtenerVentaPorId(int ventaId)
        {
            try
            {
                return repositorio.ObtenerVentaPorId(ventaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ControladoraVenta.ObtenerVentaPorId(): " + ex.Message);
            }
        }

        //validaciones mas basicas.
        private string ValidarDatosBasicos(Venta venta)
        {
            if (venta == null)
                return "La venta no puede ser nula.";

            if (venta.SucursalId <= 0)
                return "Debe seleccionar una sucursal.";

            if (venta.ClienteId <= 0)
                return "Debe seleccionar un cliente.";

            if (venta.VendedorId <= 0)
                return "Debe seleccionar un vendedor.";

            if (venta.MetodoPagoId <= 0)
                return "Debe seleccionar un método de pago.";

            if (venta.Detalles == null || venta.Detalles.Count == 0)
                return "Debe agregar al menos un producto a la venta.";

            foreach (DetalleVenta detalle in venta.Detalles)
            {
                if (detalle.ProductoId <= 0)
                    return "Hay un producto inválido en la venta.";

                if (detalle.Cantidad <= 0)
                    return "La cantidad de los productos debe ser mayor a cero.";
            }

            return "";
        }

        //que todo este en estado = activo
        private string ValidarEntidadesActivas(Venta venta)
        {
            Sucursal? sucursal =
                ControladoraSucursal.Instancia.ObtenerSucursalPorId(
                    venta.SucursalId
                );

            if (sucursal == null)
                return "La sucursal seleccionada no existe.";

            if (!sucursal.Activo)
                return "La sucursal seleccionada no está activa.";


            Cliente? cliente =
                ControladoraCliente.Instancia.ObtenerClientePorId(
                    venta.ClienteId
                );

            if (cliente == null)
                return "El cliente seleccionado no existe.";

            if (!cliente.Activo)
                return "El cliente seleccionado no está activo.";


            Vendedor? vendedor =
                ControladoraVendedor.Instancia.ObtenerVendedorPorId(
                    venta.VendedorId
                );

            if (vendedor == null)
                return "El vendedor seleccionado no existe.";

            if (!vendedor.Activo)
                return "El vendedor seleccionado no está activo.";


            MetodoPago? metodoPago =
                ControladoraMetodoPago.Instancia.ObtenerMetodoPagoPorId(
                    venta.MetodoPagoId
                );

            if (metodoPago == null)
                return "El método de pago seleccionado no existe.";

            if (!metodoPago.Activo)
                return "El método de pago seleccionado no está activo.";


            if (venta.DescuentoId.HasValue)
            {
                Descuento? descuento =
                    ControladoraDescuento.Instancia.ObtenerDescuentoPorId(
                        venta.DescuentoId.Value
                    );

                if (descuento == null)
                    return "El descuento seleccionado no existe.";

                if (!descuento.Activo)
                    return "El descuento seleccionado no está activo.";
            }


            foreach (DetalleVenta detalle in venta.Detalles)
            {
                Producto? producto =
                    ControladoraProducto.Instancia.ObtenerProductoPorId(
                        detalle.ProductoId
                    );

                if (producto == null)
                    return "Uno de los productos seleccionados no existe.";

                if (!producto.Activo)
                    return $"El producto {producto.Nombre} no está activo.";
            }

            return "";
        }

        //vendedor-sucursal
        //descuento-cliente
        //stock del producto-sucursal
        private string ValidarRelacionesYStock(Venta venta)
        {
            //vendedor pertenece a esa sucursal
            //
            Cliente? cliente =
                ControladoraCliente.Instancia.ObtenerClientePorId(
                    venta.ClienteId
                );

            Vendedor? vendedor =
                ControladoraVendedor.Instancia.ObtenerVendedorPorId(
                    venta.VendedorId
                );

            if (vendedor.SucursalId != venta.SucursalId)
            {
                return "El vendedor no pertenece a la sucursal seleccionada.";
            }

            //descuento corresponde al tipo de cliente
            if (venta.DescuentoId.HasValue)
            {
                Descuento? descuento =
                    ControladoraDescuento.Instancia.ObtenerDescuentoPorId(
                        venta.DescuentoId.Value
                    );

                if (descuento.TipoClienteId != cliente.TipoClienteId)
                {
                    return "El descuento no corresponde al tipo de cliente seleccionado.";
                }
            }

            //stock en esa sucursal
            foreach (DetalleVenta detalle in venta.Detalles)
            {
                Producto? producto =
                    ControladoraProducto.Instancia.ObtenerProductoPorId(
                        detalle.ProductoId
                    );

                Inventario? inventario =
                    ControladoraInventario.Instancia
                        .ObtenerPorProductoYSucursal(
                            detalle.ProductoId,
                            venta.SucursalId
                        );

                if (inventario == null)
                {
                    return $"{producto.Nombre} no tiene stock en la sucursal seleccionada.";
                }

                if (inventario.StockProducto < detalle.Cantidad)
                {
                    return $"No hay stock suficiente de {producto.Nombre}.";
                }
            }

            return "";
        }

        public string AgregarVenta(Venta venta)
        {
            try
            {
                //validaciones
                string validacion = ValidarDatosBasicos(venta);
                if (!string.IsNullOrEmpty(validacion))
                    return validacion;

                validacion = ValidarEntidadesActivas(venta);
                if (!string.IsNullOrEmpty(validacion))
                    return validacion;

                validacion = ValidarRelacionesYStock(venta);
                if (!string.IsNullOrEmpty(validacion))
                    return validacion;

                // Subtotal de cada detalle
                CalcularSubtotalesDetalles(venta);

                // Subtotal de la venta
                venta.MontoSubtotal = CalcularMontoSubtotal(venta);

                // Descuento
                venta.MontoDescuento = CalcularMontoDescuento(venta);

                // Total
                venta.MontoTotal = CalcularMontoTotal(venta);

                // Fecha
                venta.FechaVenta = DateTime.Now;

                // Número de venta
                venta.NumeroVenta = repositorio.ObtenerProximoNumeroVenta();

                // Guardar
                repositorio.AgregarVenta(venta);

                return "Venta registrada correctamente.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        private void CalcularSubtotalesDetalles(Venta venta)
        {
            try
            {
                foreach (DetalleVenta detalle in venta.Detalles)
                {
                    detalle.Subtotal =
                        detalle.PrecioUnitario * detalle.Cantidad;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error en ControladoraVenta.CalcularSubtotalesDetalles(): "
                    + ex.Message
                );
            }
        }
        private decimal CalcularMontoSubtotal(Venta venta)
        {
            try
            {
                return venta.Detalles.Sum(d => d.Subtotal);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error en ControladoraVenta.CalcularMontoSubtotal(): "
                    + ex.Message
                );
            }
        }
        private decimal CalcularMontoDescuento(Venta venta)
        {
            try
            {
                if (!venta.DescuentoId.HasValue)
                    return 0;

                Descuento? descuento =
                    ControladoraDescuento.Instancia
                        .ObtenerDescuentoPorId(venta.DescuentoId.Value);

                if (descuento == null)
                    return 0;

                if (descuento.TipoDeDescuento == TipoDescuento.Porcentaje)
                {
                    return venta.MontoSubtotal
                        * descuento.Valor / 100;
                }

                if (descuento.TipoDeDescuento == TipoDescuento.Fijo)
                {
                    return descuento.Valor;
                }

                return 0;
            }
            catch (Exception ex) 
            {
                throw new Exception(
                    "Error en ControladoraVenta.CalcularMontoDescuento(): " + ex.Message);
            }
        }
        private decimal CalcularMontoTotal(Venta venta)
        {
            try
            {
                decimal total = venta.MontoSubtotal - venta.MontoDescuento;

                if (total < 0)
                    return 0;

                return total;
            }
            catch (Exception ex) 
            {
                throw new Exception(
                    "Error en ControladoraVenta.CalcularMontoTotal(): " + ex.Message);
            }
        }
    }
}
