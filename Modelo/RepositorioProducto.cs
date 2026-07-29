using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;

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
                context.Producto.Add(producto);
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
                context.Producto.Update(producto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarProducto(): " + detalle);
            }
        }
        //metodos listar
        public IReadOnlyCollection<Producto> ListarProductos()
        {
            try
            {
                return context.Producto.Include(p => p.Categoria).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarProductos(): " + detalle);
            }
        }
        public IReadOnlyCollection<Producto> ListarProductosActivos()
        {
            try
            {
                return context.Producto.Where(p => p.Activo == true).Include(p => p.Categoria).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarProductosActivos(): " + detalle);
            }
        }
        public IReadOnlyCollection<Producto> ListarProductosPorNombre(string nombre)
        {
            try
            {
                return context.Producto
                .Where(producto =>
                producto.Nombre.StartsWith(nombre))
                .ToList(); ;
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarProductosPorNombre(): " + detalle
                );
            }
        }
        public IReadOnlyCollection<Producto> ListarProductosPorCategoria(int categoriaId)
        {
            try
            {
                return context.Producto
                    .Where(p => p.CategoriaId == categoriaId)
                    .Include(p=>p.Categoria)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarProductosPorCategoria(): " + detalle
                );
            }
        }
        //metodos obtener UN prod
        public Producto? ObtenerProductoPorId(int id)
        {
            try
            {
                return context.Producto.Find(id);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerProductoPorId(): " + detalle);
            }
        }
        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            try
            {
                return context.Producto
                    .FirstOrDefault(p => p.Codigo == codigo);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerProductoPorCodigo(): " + detalle
                );
            }
        }

    }
}
