using Entidades;
using Microsoft.EntityFrameworkCore;
using Entidades.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVenta
    {
        public void AgregarVenta(Venta venta)
        {
            using var context = new Context();
            using var transaccion = context.Database.BeginTransaction();

            try
            {
                //recorre los detalles que componen la venta
                foreach (DetalleVenta detalle in venta.Detalles)
                {
                    //el inverntario queda siendo seguido (tracked) por el context.
                    Inventario? inventario =
                        context.Inventario.FirstOrDefault(i =>
                            i.ProductoId == detalle.ProductoId &&
                            i.SucursalId == venta.SucursalId
                        );

                    if (inventario == null)
                    {
                        throw new Exception(
                            "El producto no tiene stock en la sucursal seleccionada."
                        );
                    }

                    if (inventario.StockProducto < detalle.Cantidad)
                    {
                        throw new Exception(
                            "No hay stock suficiente para uno de los productos."
                        );
                    }
                    //ya actualiza la tabla inventario!!! :) 
                    inventario.StockProducto -= detalle.Cantidad;

                }
                //agregar un Inventario.update seria redundante
                context.Venta.Add(venta);
                context.SaveChanges();

                transaccion.Commit();
            }
            catch (Exception ex)
            {
                transaccion.Rollback();

                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.AgregarVenta(): "
                    + detalle
                );
            }
        }

        public int ObtenerProximoNumeroVenta()
        {
            try
            {
                using var context = new Context();
                int ultimoNumero = context.Venta
                    .AsNoTracking()
                    .OrderByDescending(v => v.NumeroVenta)
                    .Select(v => v.NumeroVenta)
                    .FirstOrDefault();

                return ultimoNumero + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener el próximo número de venta: " + ex.Message
                );
            }
        }
        public IReadOnlyCollection<Venta> ListarVentas()
        {
            try
            {
                using var context = new Context();
                return context.Venta
                    .AsNoTracking()
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarVentas: " + detalle);
            }
        }

        public IReadOnlyCollection<VentaResumenDTO> ListarVentasResumen()
        {
            try
            {
                using var context = new Context();
                return context.Venta
                    .AsNoTracking()
                    .OrderByDescending(v => v.FechaVenta)
                    .ThenByDescending(v => v.NumeroVenta)
                    .Select(v => new VentaResumenDTO
                    {
                        VentaId = v.VentaId,
                        NumeroVenta = v.NumeroVenta,
                        FechaVenta = v.FechaVenta,
                        Cliente = v.Cliente.Nombre,
                        Sucursal = v.Sucursal.Nombre,
                        Vendedor = v.Vendedor.Nombre,
                        MetodoPago = v.MetodoPago.Nombre,
                        MontoSubtotal = v.MontoSubtotal,
                        MontoDescuento = v.MontoDescuento,
                        MontoTotal = v.MontoTotal,
                        EsCuentaCorriente = v.MetodoPago.EsCuentaCorriente,
                        Saldada = v.Saldada,
                        FechaSaldada = v.FechaSaldada
                    })
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarVentasResumen: " + detalle);
            }
        }

        public Venta? ObtenerVentaPorId(int ventaId)
        {
            try
            {
                //para visualizarlos en otras grillas.
                using var context = new Context();
                return context.Venta
                    .AsNoTracking()
                    .Include(v => v.Cliente)
                    .Include(v => v.Vendedor)
                    .Include(v => v.Sucursal)
                    .Include(v => v.MetodoPago)
                    .Include(v => v.Descuento)
                    .Include(v => v.Detalles)
                        .ThenInclude(d => d.Producto)
                    .FirstOrDefault(v => v.VentaId == ventaId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la venta por ID: " + ex.Message);
            }
        }

        public void MarcarComoSaldada(int ventaId, DateTime fechaSaldada)
        {
            try
            {
                using var context = new Context();
                Venta? venta = context.Venta
                    .Include(v => v.MetodoPago)
                    .FirstOrDefault(v => v.VentaId == ventaId);

                if (venta == null)
                    throw new Exception("La venta seleccionada no existe.");

                if (!venta.MetodoPago.EsCuentaCorriente)
                {
                    throw new Exception(
                        "Solo se pueden saldar ventas realizadas a cuenta corriente."
                    );
                }

                if (venta.Saldada)
                    throw new Exception("La venta seleccionada ya está saldada.");

                venta.Saldada = true;
                venta.FechaSaldada = fechaSaldada;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.MarcarComoSaldada(): " + detalle
                );
            }
        }
    }
}
