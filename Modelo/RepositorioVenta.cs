using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class RepositorioVenta
    {
        private Context context;

        public RepositorioVenta()
        {
            context = new Context();
        }
    
        public void AgregarVenta(Venta venta)
        {
            try
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarVenta(): " + detalle);
            }

        public IReadOnlyCollection<Venta> ListarVenta()
        {
            try
            {
                return context.Ventas.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarVenta: " + detalle);
            }
        }
    }
}
