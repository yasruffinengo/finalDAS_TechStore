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

        public void AgregarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                context.MetodoPago.Add(metodoPago);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.AgregarMetodoPago(): " + detalle
                );
            }
        }

        public void ModificarMetodoPago(MetodoPago metodoPago)
        {
            try
            {
                context.MetodoPago.Update(metodoPago);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ModificarMetodoPago(): " + detalle
                );
            }
        }

        public IReadOnlyCollection<MetodoPago> ListarMetodosPago()
        {
            try
            {
                return context.MetodoPago
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarMetodosPago(): " + detalle
                );
            }
        }

        public IReadOnlyCollection<MetodoPago> ListarMetodosPagoActivos()
        {
            try
            {
                return context.MetodoPago
                    .Where(m => m.Activo)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarMetodosPagoActivos(): " + detalle
                );
            }
        }

        public IReadOnlyCollection<MetodoPago> ListarMetodosPagoActivosParaCliente(
            bool esCuentacorrentista)
        {
            try
            {
                return context.MetodoPago
                    .Where(m =>
                        m.Activo &&
                        (!m.EsCuentaCorriente || esCuentacorrentista))
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarMetodosPagoActivosParaCliente(): "
                    + detalle
                );
            }
        }

        public MetodoPago? ObtenerMetodoPagoPorId(int metodoPagoId)
        {
            try
            {
                return context.MetodoPago.Find(metodoPagoId);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerMetodoPagoPorId(): " + detalle
                );
            }
        }

        public MetodoPago? ObtenerMetodoPagoPorNombre(string nombre)
        {
            try
            {
                return context.MetodoPago
                    .FirstOrDefault(m => m.Nombre == nombre);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ObtenerMetodoPagoPorNombre(): " + detalle
                );
            }
        }

    }
}
