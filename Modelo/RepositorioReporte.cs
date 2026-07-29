using Entidades;
using Entidades.Dtos;
using Entidades.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioReporte
    {
        private Context context;

        public RepositorioReporte()
        {
            context = new Context();
        }

        public List<ReporteVentaDTO> ReporteObtenerVentas(DateTime fechaDesde, DateTime fechaHasta, int? productoId, int? sucursalId, int? vendedorId)
        {
            try
            {
                DateTime desde = fechaDesde.Date;
                DateTime hasta = fechaHasta.Date.AddDays(1);

                //filtrar primero la fecha
                var consulta = context.DetalleVenta.Where(detalle =>
                        detalle.Venta.FechaVenta >= desde &&
                        detalle.Venta.FechaVenta < hasta);

                // Filtrar por producto
                if (productoId.HasValue)
                {
                    consulta = consulta.Where(detalle =>
                        detalle.ProductoId == productoId.Value);
                }

                // Filtrar por sucursal
                if (sucursalId.HasValue)
                {
                    consulta = consulta.Where(detalle =>
                        detalle.Venta.SucursalId == sucursalId.Value);
                }

                // Filtrar por vendedor
                if (vendedorId.HasValue)
                {
                    consulta = consulta.Where(detalle =>
                        detalle.Venta.VendedorId == vendedorId.Value);
                }

                return consulta
                    .OrderByDescending(detalle => detalle.Venta.FechaVenta)
                    .Select(detalle => new ReporteVentaDTO
                    {
                        IdVenta = detalle.Venta.VentaId,
                        Fecha = detalle.Venta.FechaVenta,

                        Producto = detalle.Producto.Nombre,

                        Cliente = detalle.Venta.Cliente.Nombre,

                        Sucursal = detalle.Venta.Sucursal.Nombre,

                        Vendedor = detalle.Venta.Vendedor.Nombre,

                        Cantidad = detalle.Cantidad,

                        Subtotal = detalle.Subtotal
                    })
                    .ToList();

            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ReporteObtenerVentas(): " + detalle);
            }
        }


        public List<ProductoMasVendidoDTO> ObtenerProductosMasVendidos(DateTime fechaDesde, DateTime fechaHasta, int? sucursalId)
        {

            try
            {
                DateTime desde = fechaDesde.Date;
                DateTime hasta = fechaHasta.Date.AddDays(1);

                //filtrar primero la fecha
                var consulta = context.DetalleVenta.Where(detalle =>
                        detalle.Venta.FechaVenta >= desde &&
                        detalle.Venta.FechaVenta < hasta);

                // Filtrar por sucursal
                if (sucursalId.HasValue)
                {
                    consulta = consulta.Where(detalle =>
                        detalle.Venta.SucursalId == sucursalId.Value);
                }

                return consulta.GroupBy(detalle => new   //junta todos los detalles correspondientes al mismo producto
                {
                    detalle.ProductoId,
                    detalle.Producto.Nombre
                })
            .Select(grupo => new ProductoMasVendidoDTO //crea un objeto ProductoMasVendidoDTO para cada grupo de detalles
            {
                IdProducto = grupo.Key.ProductoId,
                NombreProducto = grupo.Key.Nombre,

                CantidadVendida = grupo.Sum(detalle => detalle.Cantidad), //Suma todas las unidades vendidas de ese producto

                TotalVendido = grupo.Sum(detalle => detalle.Subtotal) //suma en plata
            }).OrderByDescending(producto => producto.CantidadVendida).ToList(); //ordena desde el producto más vendido hasta el menos vendido y lo lista
            
            } catch (Exception ex) {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerProductosMasVendidos(): " + detalle);
            }
        }
        
    
        public List<EstadoCuentaClienteDTO> ObtenerEstadoCuentasCorrientes(
            int? clienteId)
        {
            try
            {
                var consulta = context.Cliente
                    .AsNoTracking()
                    .Where(c =>
                        c.EsCuentacorrentista ||
                        c.Ventas.Any(v => v.MetodoPago.EsCuentaCorriente));

                if (clienteId.HasValue)
                {
                    consulta = consulta.Where(c =>
                        c.ClienteId == clienteId.Value);
                }

                return consulta
                    .Select(c => new EstadoCuentaClienteDTO
                    {
                        IdCliente = c.ClienteId,
                        Cliente = c.Nombre,
                        TotalCompras = c.Ventas
                            .Where(v => v.MetodoPago.EsCuentaCorriente)
                            .Sum(v => (decimal?)v.MontoTotal) ?? 0m,
                        TotalPagado = c.Ventas
                            .Where(v =>
                                v.MetodoPago.EsCuentaCorriente &&
                                v.Saldada)
                            .Sum(v => (decimal?)v.MontoTotal) ?? 0m,
                        SaldoPendiente = c.Ventas
                            .Where(v =>
                                v.MetodoPago.EsCuentaCorriente &&
                                !v.Saldada)
                            .Sum(v => (decimal?)v.MontoTotal) ?? 0m
                    })
                    .OrderBy(c => c.Cliente)
                    .ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerEstadoCuentasCorrientes(): "
                    + detalle
                );
            }
        }

        public List<DetalleCuentaCorrienteDTO> ObtenerDetalleCuentaCorriente(
            int clienteId)
        {
            try
            {
                return context.Venta
                    .AsNoTracking()
                    .Where(v =>
                        v.ClienteId == clienteId &&
                        v.MetodoPago.EsCuentaCorriente)
                    .OrderByDescending(v => v.FechaVenta)
                    .ThenByDescending(v => v.NumeroVenta)
                    .Select(v => new DetalleCuentaCorrienteDTO
                    {
                        VentaId = v.VentaId,
                        NumeroVenta = v.NumeroVenta,
                        FechaVenta = v.FechaVenta,
                        MontoTotal = v.MontoTotal,
                        Saldada = v.Saldada,
                        FechaSaldada = v.FechaSaldada
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerDetalleCuentaCorriente(): "
                    + detalle
                );
            }
        }
      }
}



