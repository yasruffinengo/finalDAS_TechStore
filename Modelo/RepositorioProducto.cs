using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class RepositorioProducto
    {
        private Context context;

        public RepositorioProducto()
        {
            context = new Context();
        }

        public void AgregarProducto(Producto producto)
        {
            try
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarProducto(): " + detalle);
            }
        }

        public void ModificarProducto(Producto producto)
        {
            try
            {
                context.Productos.Update(producto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarProducto(): " + detalle);
            }
        }
        public void EliminarProducto(Producto producto)
        {
            try
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarProducto(): " + detalle);
            }
        }
        public IReadOnlyCollection<Producto> ListarProductos()
        {
            try
            {
                return context.Productos.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarProductos(): " + detalle);
            }
        }
        public Producto ObtenerProductoPorId(int id)
        {
            try
            {
                return context.Productos.Find(id);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerProductoPorId(): " + detalle);
            }
        }

    }
}
