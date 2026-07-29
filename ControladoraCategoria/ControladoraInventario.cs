using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraInventario
    {
        private RepositorioInventario repositorio = new RepositorioInventario();

        private static ControladoraInventario instancia;

        private ControladoraInventario()
        {

        }
        public static ControladoraInventario Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraInventario();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        private string ValidarInventario(Inventario inventario)
        {
            if (inventario.ProductoId <= 0)
                return "Debe seleccionar un producto.";

            if (inventario.SucursalId <= 0)
                return "Debe seleccionar una sucursal.";

            if (inventario.StockProducto < 0)
                return "El stock no puede ser negativo.";

            return "";
        }

        public string GuardarInventario(Inventario inventario)
        {
            try
            {
                string validacion = ValidarInventario(inventario);

                if (validacion != "")
                    return validacion;

                //chequea si ya existe un inventario de este prod y esta sucursal
                Inventario? inventarioExistente =
                    repositorio.ObtenerPorProductoYSucursal(inventario.ProductoId, inventario.SucursalId);
                //crea uno 
                if (inventarioExistente == null)
                {
                    repositorio.AgregarInventario(inventario);

                    return "Inventario agregado correctamente.";
                }
                //se actualiza el inventario de ese prod en esa sucursal
                inventarioExistente.StockProducto = inventario.StockProducto;
                //actualiza en la bdd
                repositorio.ModificarInventario(inventarioExistente);

                return "Inventario actualizado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al guardar el inventario: " + detalle;
            }
        }

        public Inventario? ObtenerPorProductoYSucursal(int productoId, int sucursalId)
        {
            return repositorio.ObtenerPorProductoYSucursal(
                productoId,
                sucursalId
            );
        }

        public IReadOnlyCollection<Inventario> ListarInventarios()
        {
            return repositorio.ListarInventarios();
        }

        public IReadOnlyCollection<Inventario> ListarPorSucursal(int sucursalId)
        {
            return repositorio.ListarPorSucursal(sucursalId);
        }
        public IReadOnlyCollection<Inventario> ListarInventariosPorSucursal(int sucursalId)
        {
            try
            {
                if (sucursalId <= 0)
                {
                    throw new Exception(
                        "Debe seleccionar una sucursal."
                    );
                }

                return repositorio
                    .ListarInventariosPorSucursal(
                        sucursalId
                    );
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error en ControladoraInventario.ListarInventariosPorSucursal(): "
                    + ex.Message
                );
            }
        }
    }
}
