using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProducto
    {
        private RepositorioProducto repositorio = new RepositorioProducto();

        private static ControladoraProducto instancia;

        private ControladoraProducto()
        {

        }
        public static ControladoraProducto Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraProducto();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }
        public string AgregarProducto(Producto producto)
        {
            try
            {
                string validacion = ValidarProducto(producto);

                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarProducto(producto);

                return "Producto agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar producto: " + detalle;
            }
        }

        public string ModificarProducto(Producto producto)
        {
            try
            {
                string validacion = ValidarProducto(producto);

                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarProducto(producto);

                return "Producto modificado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al modificar producto: " + detalle;
            }
        }

        public string CambiarEstadoProducto(int productoId)
        {
            try
            {
                Producto? producto =
                    repositorio.ObtenerProductoPorId(productoId);

                if (producto == null)
                    return "Error: Producto no encontrado.";
                producto.Activo = !producto.Activo;
                repositorio.ModificarProducto(producto);

                return producto.Activo
                    ? "Producto activado correctamente."
                    : "Producto desactivado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al cambiar el estado del producto: " + detalle;
            }

        }

        public IReadOnlyCollection<Producto> ListarProductos()
        {
            try
            {
                return repositorio.ListarProductos();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al listar los productos: " + ex.Message
                );
            }
        }

        public IReadOnlyCollection<Producto> ListarProductosActivos()
        {
            try
            {
                return repositorio.ListarProductosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al listar los productos activos: " + ex.Message
                );
            }
        }

        public IReadOnlyCollection<Producto> ListarProductosPorNombre(
            string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    return repositorio.ListarProductos();
                }

                return repositorio
                    .ListarProductosPorNombre(nombre.Trim());
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al listar los productos por nombre: " + ex.Message
                );
            }
        }

        public IReadOnlyCollection<Producto> ListarProductosPorCategoria(
            int categoriaId)
        {
            try
            {
                if (categoriaId <= 0)
                {
                    throw new Exception(
                        "Debe seleccionar una categoría."
                    );
                }

                return repositorio
                    .ListarProductosPorCategoria(categoriaId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al listar los productos por categoría: " + ex.Message
                );
            }
        }

        public Producto? ObtenerProductoPorId(int productoId)
        {
            try
            {
                return repositorio.ObtenerProductoPorId(productoId);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener el producto por ID: " + ex.Message
                );
            }
        }

        public Producto? ObtenerProductoPorCodigo(string codigo)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    throw new Exception(
                        "Debe ingresar un código de producto."
                    );
                }

                return repositorio
                    .ObtenerProductoPorCodigo(codigo.Trim());
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener el producto por código: " + ex.Message
                );
            }
        }

        private string ValidarProducto(Producto producto)
        {
            try
            {
                if (producto == null)
                    return "Error: El producto no puede ser nulo.";

                if (string.IsNullOrWhiteSpace(producto.Nombre))
                    return "Error: El nombre del producto es obligatorio.";

                producto.Nombre = producto.Nombre.Trim();

                if (producto.Nombre.Length < 3)
                    return "Error: El nombre debe tener al menos 3 caracteres.";

                if (string.IsNullOrWhiteSpace(producto.Codigo))
                    return "Error: El código del producto es obligatorio.";

                producto.Codigo = producto.Codigo.Trim();

                Producto? productoExistente =
                    repositorio.ObtenerProductoPorCodigo(producto.Codigo);

                if (productoExistente != null &&
                    productoExistente.ProductoId != producto.ProductoId)
                {
                    return "Error: Ya existe otro producto con ese código.";
                }

                producto.Descripcion =
                    producto.Descripcion?.Trim() ?? string.Empty;

                if (producto.MontoUnitario <= 0)
                    return "Error: El monto unitario debe ser mayor a cero.";

                if (producto.CategoriaId <= 0)
                    return "Error: Debe seleccionar una categoría.";

                return "OK";
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al validar el producto: " + ex.Message
                );
            }
        }

    }
}
