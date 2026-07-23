using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraVendedor
    {
        private RepositorioVendedor repositorio = new RepositorioVendedor();

        private static ControladoraVendedor instancia;

        private ControladoraVendedor()
        {

        }
        public static ControladoraVendedor Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraVendedor();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarVendedor(Vendedor vendedor)
        {
            try
            {
                string validacion = ValidarVendedor(vendedor);

                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarVendedor(vendedor);

                return "Vendedor agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar vendedor: " + detalle;
            }
        }

        private string ValidarVendedor(Vendedor vendedor)
        {
            if (vendedor == null)
                return "Error: El vendedor no puede ser nulo.";

            // Nombre
            if (string.IsNullOrWhiteSpace(vendedor.Nombre))
                return "Error: El nombre del vendedor es obligatorio.";

            vendedor.Nombre = vendedor.Nombre.Trim();

            if (vendedor.Nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            // Apellido
            if (string.IsNullOrWhiteSpace(vendedor.Apellido))
                return "Error: El apellido del vendedor es obligatorio.";

            vendedor.Apellido = vendedor.Apellido.Trim();

            if (vendedor.Apellido.Length < 3)
                return "Error: El apellido debe tener al menos 3 caracteres.";

            // Sucursal
            if (vendedor.SucursalId <= 0)
                return "Error: Debe seleccionar una sucursal.";

            return "OK";
        }

        public string ModificarVendedor(Vendedor vendedor)
        {
            try
            {
                string validacion = ValidarVendedor(vendedor);

                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarVendedor(vendedor);

                return "Vendedor modificado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar vendedor: " + detalle;
            }
        }

        public List<Vendedor> ListarVendedores()
        {
            try
            {
                return repositorio.ListarVendedores().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar vendedores: " + ex.Message);
            }
        }

        public List<Vendedor> ListarVendedoresActivos()
        {
            try
            {
                return repositorio.ListarVendedoresActivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar vendedores activos: " + ex.Message);
            }
        }

        public string CambiarEstadoVendedor(int vendedorId)
        {
            try
            {
                Vendedor? vendedor =
                    repositorio.ObtenerVendedorPorId(vendedorId);

                if (vendedor == null)
                    return "Error: El vendedor no existe.";

                vendedor.Activo = !vendedor.Activo;

                repositorio.ModificarVendedor(vendedor);

                if (vendedor.Activo)
                    return "Vendedor activado ocorrectamente.";

                return "Vendedor desactivado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al cambiar el estado del vendedor: " + detalle;
            }
        }
    }
}
