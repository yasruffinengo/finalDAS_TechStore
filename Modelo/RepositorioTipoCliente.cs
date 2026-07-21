using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioTipoCliente
    {
        private Context context;

        public RepositorioTipoCliente()
        {
            context = new Context();
        }
        public IReadOnlyCollection<TipoCliente> ListarTiposCliente()
        {
            try
            {
                return context.TipoCliente
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarTiposCliente(): " + detalle);
            }
        }
    }
}
