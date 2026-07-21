using Entidades;
using Modelo;
using System.Text.RegularExpressions;

namespace ControladoraCliente
{
    public class ControladoraCliente
    {
        private RepositorioCliente repositorio = new RepositorioCliente();

        private static ControladoraCliente instancia;

        private ControladoraCliente()
        {

        }
        public static ControladoraCliente Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraCliente();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarCliente(Cliente cliente)
        {
            try
            {
                string validacion = ValidarCliente(cliente);
                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarCliente(cliente);
                return "Cliente agregado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar cliente: " + detalle;
            }
        }

        private string ValidarCliente(Cliente cliente)
        {
            if (cliente == null)
                return "Error: El cliente no puede ser nulo.";

            // Nombre obligatorio
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                return "Error: El nombre del cliente es obligatorio.";

            cliente.Nombre = cliente.Nombre.Trim();

            if (cliente.Nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            // Documento
            if (string.IsNullOrWhiteSpace(cliente.NumeroDocumento))
                return "Error: El número de documento es obligatorio.";

            cliente.NumeroDocumento = cliente.NumeroDocumento.Trim();

            if (!Regex.IsMatch(cliente.NumeroDocumento, @"^\d{7,11}$"))
                return "Error: El documento debe contener entre 7 y 11 números.";

            Cliente? clienteExistente =
                repositorio.ObtenerClientePorDni(cliente.NumeroDocumento);

            if (clienteExistente != null &&
                clienteExistente.ClienteId != cliente.ClienteId)
            {
                return "Error: Ya existe otro cliente con ese número de documento.";
            }

            // Teléfono
            if (string.IsNullOrWhiteSpace(cliente.Telefono))
                return "Error: El teléfono es obligatorio.";

            cliente.Telefono = cliente.Telefono.Trim();

            if (!Regex.IsMatch(cliente.Telefono, @"^[0-9+\-\s()]{8,20}$"))
                return "Error: El formato del teléfono no es válido.";

            // Email
            if (string.IsNullOrWhiteSpace(cliente.Email))
                return "Error: El correo electrónico es obligatorio.";

            cliente.Email = cliente.Email.Trim();

            if (!Regex.IsMatch(cliente.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                return "Error: El formato del correo electrónico no es válido.";

            // Domicilio
            if (string.IsNullOrWhiteSpace(cliente.Domicilio))
                return "Error: El domicilio es obligatorio.";

            cliente.Domicilio = cliente.Domicilio.Trim();

            if (cliente.Domicilio.Length < 5)
                return "Error: El domicilio debe tener al menos 5 caracteres.";

            // Tipo de cliente
            if (cliente.TipoClienteId != 1 &&
                cliente.TipoClienteId != 2)
            {
                return "Error: Debe seleccionar un tipo de cliente válido.";
            }

            return "OK";
        }

        public string ModificarCliente(Cliente cliente)
        {
            try
            {
                string validacion = ValidarCliente(cliente);
                if (validacion != "OK")
                {
                    return validacion;
                }

                repositorio.ModificarCliente(cliente);
                return "Categoria modificada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar categoria: " + detalle;
            }
        }

        public string EliminarCliente(int idCliente)
        {
            try
            {
                // Buscar antes de eliminar
                Cliente? cliente = repositorio.ObtenerClientePorId(idCliente);

                if (cliente == null)
                    return "Error: el cliente no existe o ya fue eliminado.";

                // Si existe, eliminar
                repositorio.EliminarCliente(cliente);
                return "Cliente eliminado correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al eliminar cliente: " + detalle;
            }
        }

        public List<Cliente> ListarClientes()
        {
            try
            {
                return repositorio.ListarClientes().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar clientes" + ex.Message);
            }

        }
    }
}