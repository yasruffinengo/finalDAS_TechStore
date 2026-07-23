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
    public class ControladoraSucursal
    {
        private RepositorioSucursal repositorio = new RepositorioSucursal();

        private static ControladoraSucursal instancia;

        private ControladoraSucursal()
        {

        }
        public static ControladoraSucursal Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraSucursal();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarSucursal(Sucursal sucursal)
        {
            try
            {
                string validacion = ValidarSucursal(sucursal);

                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarSucursal(sucursal);

                return "Sucursal agregada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar sucursal: " + detalle;
            }
        }

        private string ValidarSucursal(Sucursal sucursal)
        {
            if (sucursal == null)
                return "Error: La sucursal no puede ser nula.";

            // Nombre
            if (string.IsNullOrWhiteSpace(sucursal.Nombre))
                return "Error: El nombre de la sucursal es obligatorio.";

            sucursal.Nombre = sucursal.Nombre.Trim();

            if (sucursal.Nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            Sucursal? sucursalExistente =
                repositorio.ObtenerSucursalPorNombre(sucursal.Nombre);

            if (sucursalExistente != null &&
                sucursalExistente.SucursalId != sucursal.SucursalId)
            {
                return "Error: Ya existe otra sucursal con ese nombre.";
            }

            // Domicilio
            if (string.IsNullOrWhiteSpace(sucursal.Domicilio))
                return "Error: El domicilio es obligatorio.";

            sucursal.Domicilio = sucursal.Domicilio.Trim();

            if (sucursal.Domicilio.Length < 5)
                return "Error: El domicilio debe tener al menos 5 caracteres.";

            // Teléfono
            if (string.IsNullOrWhiteSpace(sucursal.Telefono))
                return "Error: El teléfono es obligatorio.";

            sucursal.Telefono = sucursal.Telefono.Trim();

            if (!Regex.IsMatch(sucursal.Telefono, @"^[0-9+\-\s()]{8,20}$"))
                return "Error: El formato del teléfono no es válido.";

            // Email
            if (string.IsNullOrWhiteSpace(sucursal.Email))
                return "Error: El correo electrónico es obligatorio.";

            sucursal.Email = sucursal.Email.Trim();

            if (!Regex.IsMatch(sucursal.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Error: El formato del correo electrónico no es válido.";

            return "OK";
        }

        public string ModificarSucursal(Sucursal sucursal)
        {
            try
            {
                string validacion = ValidarSucursal(sucursal);

                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarSucursal(sucursal);

                return "Sucursal modificada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar sucursal: " + detalle;
            }
        }

        public List<Sucursal> ListarSucursales()
        {
            try
            {
                return repositorio.ListarSucursales().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar sucursales: " + ex.Message);
            }
        }

        public List<Sucursal> ListarSucursalesActivas()
        {
            try
            {
                return repositorio.ListarSucursalesActivas().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar sucursales activas: " + ex.Message);
            }
        }

        public string CambiarEstadoSucursal(int sucursalId)
        {
            try
            {
                Sucursal? sucursal =
                    repositorio.ObtenerSucursalPorId(sucursalId);

                if (sucursal == null)
                    return "Error: La sucursal no existe.";

                sucursal.Activo = !sucursal.Activo;

                repositorio.ModificarSucursal(sucursal);

                if (sucursal.Activo)
                    return "Sucursal activada correctamente.";

                return "Sucursal desactivada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al cambiar el estado de la sucursal: " + detalle;
            }
        }
    }
}
