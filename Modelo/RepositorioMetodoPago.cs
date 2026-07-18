using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class RepositorioMetodoPago
    {

        private Context context;

        public RepositorioMetodoPago()
        { 
            context = new Context();
        }

        public IReadOnlyCollection<MetodoPago> ListarMetodoPago()
        {
            try
            {
                return context.MetodoPago.Where(m => m.Activo == true).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarMetodoPago: " + detalle);
            }
        }

        public void AgregarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                context.MetodoPago.Add(metodoPago);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarMetodoPago: " + detalle);
            }
        }
        public void EliminarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                metodoPago.Activo = false;
                context.MetodoPago.Update(metodoPago);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarMetodoPago(): " + detalle);
            }
        }

        public void ModificarMetodoPago (MetodoPago metodoPago)
        {
            try
            {
                context.Update(metodoPago);
                context.SaveChanges();
            }
            
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarMetodoPago(): " + detalle);
            }
        }

    }
}
