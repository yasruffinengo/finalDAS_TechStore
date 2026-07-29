using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraMetodoPago
    {
        private RepositorioMetodoPago repositorio = new RepositorioMetodoPago();

        private static ControladoraMetodoPago instancia;

        private ControladoraMetodoPago()
        {

        }
        public static ControladoraMetodoPago Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraMetodoPago();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                string validacion = ValidarMetodoPago(metodoPago);

                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarMetodoPago(metodoPago);

                return "Metodo de pago agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar Metodo de pago: " + detalle;
            }
        }

        private string ValidarMetodoPago(MetodoPago metodoPago)
        {
            if (metodoPago == null)
                return "Error: El Metodo de pago no puede ser nulo.";

            // Nombre
            if (string.IsNullOrWhiteSpace(metodoPago.Nombre))
                return "Error: El nombre del Metodo de pago es obligatorio.";

            metodoPago.Nombre = metodoPago.Nombre.Trim();

            if (metodoPago.Nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            // Evitar nombres repetidos
            MetodoPago? metodoPagoExistente =
                repositorio.ObtenerMetodoPagoPorNombre(metodoPago.Nombre);

            if (metodoPagoExistente != null &&
                metodoPagoExistente.MetodoPagoId != metodoPago.MetodoPagoId)
            {
                return "Error: Ya existe otro Metodo de pago con ese nombre.";
            }

            // Descripción
            if (string.IsNullOrWhiteSpace(metodoPago.Descripcion))
                return "Error: La descripción del Metodo de pago es obligatoria.";

            metodoPago.Descripcion = metodoPago.Descripcion.Trim();

            if (metodoPago.Descripcion.Length < 5)
                return "Error: La descripción debe tener al menos 5 caracteres.";

            return "OK";
        }

        public string ModificarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                string validacion = ValidarMetodoPago(metodoPago);

                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarMetodoPago(metodoPago);

                return "Metodo de pago modificado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar Metodo de pago: " + detalle;
            }
        }

        public List<MetodoPago> ListarMetodosPago()
        {
            try
            {
                return repositorio.ListarMetodosPago().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Metodos de pago: " + ex.Message);
            }
        }

        public List<MetodoPago> ListarMetodosPagoActivos()
        {
            try
            {
                return repositorio.ListarMetodosPagoActivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Metodo de pago activos: " + ex.Message);
            }
        }

        public string CambiarEstadoMetodoPago(int metodoPagoId)
        {
            try
            {
                MetodoPago? mp =
                    repositorio.ObtenerMetodoPagoPorId(metodoPagoId);

                if (mp == null)
                    return "Error: El Metodo de pago no existe.";

                mp.Activo = !mp.Activo;

                repositorio.ModificarMetodoPago(mp);

                if (mp.Activo)
                    return "Metodo de pago activado correctamente.";

                return "Metodo de pago desactivado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al cambiar el estado del metodo de pago: " + detalle;
            }
        }
        public MetodoPago? ObtenerMetodoPagoPorId(int id)
        {
            try
            {
                return repositorio.ObtenerMetodoPagoPorId(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el metodo de pago por ID: " + ex.Message);
            }
        }
    }
}
