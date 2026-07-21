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
                context.Descuento.Add(descuento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarDescuento(): " + detalle);
            }
        }
        public void ModificarDescuento(Descuento descuento)
        {
            try
            {
                context.Descuento.Update(descuento);
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
                context.Descuento.Update(descuento);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarDecuento(): " + detalle);
            }
        }
        public IReadOnlyCollection<Descuento> ListarDescuentosActivos()
        {
            try
            {

                return context.Descuento.Where(d => d.Activo == true).ToList().AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarDescuentos(): " + detalle);
            }
        }

        public Descuento? ObtenerDescuentoPorId(int id)
        {
            try
            {
                return context.Descuento.Find(id);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerDescuentoPorId(): " + detalle);
            }
        }
        public Descuento? ObtenerDescuentoPorNombre(string nombre)
        {
            try
            {
                return context.Descuento.FirstOrDefault(d => d.Nombre == nombre);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerDescuentoPorNombre(): " + detalle
                );
            }
        }

        public IReadOnlyCollection<Descuento> ObtenerDescuentosPorTipoCliente(int tipoClienteId)
        {
            try
            {
                return context.Descuento
                    .Where(d => d.TipoClienteId == tipoClienteId)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerDescuentosPorTipoCliente(): " + detalle
                );
            }
        }
        /*
        public decimal CalcularMontoDescuento(Cliente cliente, decimal subtotal)
        {
            try
            {
                Descuento descuento = ObtenerDescuentoPorTipoCliente(cliente);

                if (descuento == null)
                    return 0;

                decimal montoDescuento = 0;

                if (descuento.TipoDeDescuento == TipoDescuento.Fijo)
                {
                    montoDescuento = descuento.Monto;
                }
                else
                {
                    montoDescuento = subtotal * descuento.Monto / 100m;
                }

                return montoDescuento;
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.CalcularMontoDescuento(): " + detalle);
            }
        }
        */
    }
}
