using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVenta
    {
        private Context context;

        public RepositorioVenta()
        {
            context = new Context();
        }

        public void AgregarVenta(Venta venta)
        {
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
                int ultimoNumero = context.Venta
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
                return context.Venta.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarVentas: " + detalle);
            }
        }

        public Venta? ObtenerVentaPorId(int ventaId)
        {
            try
            {
                //para visualizarlos en otras grillas.
                return context.Venta
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
    }
}
