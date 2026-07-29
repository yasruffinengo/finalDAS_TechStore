using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioInventario
    {
        public void AgregarInventario(Inventario inventario)
        {
            try
            {
                using var context = new Context();
                context.Inventario.Add(inventario);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarInventario(): " + detalle);
            }

        }

        public void ModificarInventario(Inventario inventario)
        {
            try
            {
                using var context = new Context();
                context.Inventario.Update(inventario);
                context.SaveChanges();
            }
            catch (Exception ex) 
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarInventario(): " + detalle);
            }

        }

        //objeto Inventario de tal producto en tal sucursal
        public Inventario? ObtenerPorProductoYSucursal(int productoId, int sucursalId)
        {
            try
            {
                using var context = new Context();
                return context.Inventario
                    .AsNoTracking()
                    .FirstOrDefault(i => i.ProductoId == productoId && i.SucursalId == sucursalId);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerPorProductoYSucursal(): " + detalle);
            }
        }
        //lista todos los inventarios
        public IReadOnlyCollection<Inventario> ListarInventarios()
        {
            try
            {
                using var context = new Context();
                return context.Inventario
                    .AsNoTracking()
                    .Include(i => i.Producto)
                    .Include(i => i.Sucursal)
                    .ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarInventarios(): " + detalle);
            }
        }
        //lista inventarios por una sucursal
        public IReadOnlyCollection<Inventario> ListarPorSucursal(int sucursalId)
        {

            try
            {
                using var context = new Context();
                return context.Inventario
                    .AsNoTracking()
                    .Include(i => i.Producto)
                    .Include(i => i.Sucursal)
                    .Where(i => i.SucursalId == sucursalId)
                    .ToList();
            } catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarPorSucursal(): " + detalle);
            }
        }
        public IReadOnlyCollection<Inventario> ListarInventariosPorSucursal(int sucursalId)
        {
            try
            {
                using var context = new Context();
                return context.Inventario
                    .AsNoTracking()
                    .Include(i => i.Producto)
                    .Include(i => i.Sucursal)
                    .Where(i =>
                        i.SucursalId == sucursalId &&
                        i.Producto.Activo &&
                        i.StockProducto > 0)
                    .OrderBy(i => i.Producto.Nombre)
                    .ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en RepositorioInventario.ListarInventariosPorSucursal(): "
                    + detalle
                );
            }
        }
    }
}
