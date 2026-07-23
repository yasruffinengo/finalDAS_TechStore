using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraDescuento
    {
        private RepositorioDescuento repositorio = new RepositorioDescuento();

        private static ControladoraDescuento instancia;

        private ControladoraDescuento()
        {

        }
        public static ControladoraDescuento Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraDescuento();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarDescuento(Descuento descuento)
        {
            try
            {
                string validacion = ValidarDescuento(descuento);

                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarDescuento(descuento);

                return "Descuento agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar descuento: " + detalle;
            }
        }
        private string ValidarDescuento(Descuento descuento)
        {
            if (descuento == null)
                return "Error: El descuento no puede ser nulo.";

            // Nombre
            if (string.IsNullOrWhiteSpace(descuento.Nombre))
                return "Error: El nombre del descuento es obligatorio.";

            descuento.Nombre = descuento.Nombre.Trim();

            if (descuento.Nombre.Length < 3)
                return "Error: El nombre del descuento debe tener al menos 3 caracteres.";

            // Nombre repetido
            Descuento? descuentoExistente =
                repositorio.ObtenerDescuentoPorNombre(descuento.Nombre);

            if (descuentoExistente != null &&
                descuentoExistente.DescuentoId != descuento.DescuentoId)
            {
                return "Error: Ya existe otro descuento con ese nombre.";
            }

            // Valor
            if (descuento.Valor <= 0)
                return "Error: El valor del descuento debe ser mayor que cero.";

            if (descuento.TipoDeDescuento == TipoDescuento.Porcentaje &&
                descuento.Valor > 100)
            {
                return "Error: El descuento porcentual no puede superar el 100%.";
            }

            // Tipo de cliente
            if (descuento.TipoClienteId <= 0)
                return "Error: Debe seleccionar un tipo de cliente.";

            return "OK";
        }

        public string ModificarDescuento(Descuento descuento)
        {
            try
            {
                string validacion = ValidarDescuento(descuento);

                if (validacion != "OK")
                    return validacion;

                repositorio.ModificarDescuento(descuento);

                return "Descuento modificado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar descuento: " + detalle;
            }
        }

        public List<Descuento> ListarDescuentos()
        {
            try
            {
                return repositorio.ListarDescuentos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar descuentos: " + ex.Message);
            }
        }

        public List<Descuento> ListarDescuentosActivos()
        {
            try
            {
                return repositorio.ListarDescuentosActivos().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar descuentos activos: " + ex.Message);
            }
        }

        public string CambiarEstadoDescuento(int descuentoId)
        {
            try
            {
                Descuento? descuento =
                    repositorio.ObtenerDescuentoPorId(descuentoId);

                if (descuento == null)
                    return "Error: El descuento no existe.";

                descuento.Activo = !descuento.Activo;

                repositorio.ModificarDescuento(descuento);

                if (descuento.Activo)
                    return "Descuento activado correctamente.";

                return "Descuento desactivado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                return "Error al cambiar el estado del descuento: " + detalle;
            }
        }
        public List<Descuento> ObtenerDescuentosPorTipoCliente(int tipoClienteId)
        {
            try
            {
                return repositorio
                    .ObtenerDescuentosPorTipoCliente(tipoClienteId)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al obtener descuentos por tipo de cliente: "
                    + ex.Message
                );
            }
        }
    }
}
