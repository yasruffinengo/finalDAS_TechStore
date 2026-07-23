using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class RepositorioCliente
    {
        private Context context;

        public RepositorioCliente()
        {
            context = new Context();
        }

        public void AgregarCliente(Cliente cliente)
        {
            try
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarCliente(): " + detalle);
            }
        }

        public void ModificarCliente(Cliente cliente)
        {
            try
            {
                context.Cliente.Update(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarCliente(): " + detalle);
            }
        }
        //se llama eliminar, pero es BAJA LOGICA
        //cambia el estado. 
        public IReadOnlyCollection<Cliente> ListarClientesActivos()
        {
            try
            {
                return context.Cliente.Where(c => c.Activo == true).ToList().AsReadOnly();
                
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarClientesActivos(): " + detalle);
            }
        }
        public IReadOnlyCollection<Cliente> ListarClientes()
        {

            try
            {
                return context.Cliente
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarClientes(): " + detalle
                );
            }
        
        }
        public Cliente ObtenerClientePorId(int id)
        {
            try
            {
                return context.Cliente.Find(id);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerClientePorId(): " + detalle);
            }
        }
        public Cliente ObtenerClientePorDni(string dni)
        {
            try
            {
                return context.Cliente.FirstOrDefault(c => c.NumeroDocumento == dni);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerClientePorDni(): " + detalle
                );
            }
        }
    }
}
