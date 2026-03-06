using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioDescuento
    {
        private Context context;

        public RepositorioDescuento()
        {
            context = new Context();
        }
        public void AgregarDescuento(Descuento descuento)
        {
            try
            {
                context.Descuentos.Add(descuento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarDescuento(): " + detalle);
            }
        }
        public IReadOnlyCollection<Descuento> ListarDescuentos()
        {
            try
            {

                return context.Descuentos.Where(d => d.Activo == true).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarDescuentos(): " + detalle);
            }
        }

        public void ModificarDescuento(Descuento descuento)
        {
            try
            {
                context.Descuentos.Update(descuento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarDescuento(): " + detalle);
            }
        }
        public void EliminarDescuento(Descuento descuento)
        {
            try
            {
                descuento.Activo = false;
                context.Descuentos.Update(descuento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarDecuento(): " + detalle);
            }
        }
        public Descuento ObtenerDescuentoPorTipoCliente(Cliente cliente)
        {
            try
            {
                Descuento descuento = context.Descuentos.Where(d => d.Activo && d.TipoCliente == cliente.TipoDeCliente).FirstOrDefault();

                return descuento;
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerDescuentoPorTipoCliente(): " + detalle);
            }
        }

        public decimal CalcularMontoDescuento(Cliente cliente, decimal subtotal)
        {
            try
            {
                Descuento descuento = ObtenerDescuentoPorTipoCliente(cliente);

                if (descuento == null)
                    return 0;

                decimal montoDescuento = 0;

                if (descuento.TipoDeDescuento == TipoDescuento.MontoFijo)
                {
                    montoDescuento = descuento.Valor;
                }
                else
                {
                    montoDescuento = subtotal * descuento.Valor / 100m;
                }

                return montoDescuento;
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.CalcularMontoDescuento(): " + detalle);
            }
        }
    }
}
