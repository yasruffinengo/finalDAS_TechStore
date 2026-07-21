using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraTipoCliente
    {
        private RepositorioTipoCliente repositorio = new RepositorioTipoCliente();

        private static ControladoraTipoCliente instancia;

        private ControladoraTipoCliente()
        {

        }
        public static ControladoraTipoCliente Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraTipoCliente();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }
        public List<TipoCliente> ListarTiposCliente()
        {
            try
            {
                return repositorio.ListarTiposCliente().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar tipos de cliente" + ex.Message);
            }

        }
    }
}
