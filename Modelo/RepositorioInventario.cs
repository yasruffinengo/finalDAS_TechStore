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
        private Context context;

        public RepositorioInventario()
        {
            context = new Context();
        }

        public void AgregarInventario(Inventario inventario)
        {
            try
            {
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
                return context.Inventario.FirstOrDefault(i => i.ProductoId == productoId && i.SucursalId == sucursalId);
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
                return context.Inventario
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
                return context.Inventario
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
    }
}
