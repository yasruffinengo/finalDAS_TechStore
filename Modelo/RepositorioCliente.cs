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
                context.Clientes.Add(cliente);
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
                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarCliente(): " + detalle);
            }
        }
        public void EliminarCliente(Cliente cliente)
        {
            try
            {
                cliente.Activo = false;
                context.Clientes.Update(cliente);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarCliente(): " + detalle);
            }
        }
        public IReadOnlyCollection<Cliente> ListarClientes()
        {
            try
            {
                return context.Clientes.Where(c => c.Activo == true).ToList();
                
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarClientes(): " + detalle);
            }
        }


    }
}
