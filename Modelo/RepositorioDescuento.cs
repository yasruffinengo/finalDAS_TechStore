using Entidades;
using Microsoft.EntityFrameworkCore;
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
        
        public IReadOnlyCollection<Descuento> ListarDescuentosActivos()
        {
            try
            {

                return context.Descuento.Where(d => d.Activo == true).ToList().AsReadOnly().ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarDescuentosActivos(): " + detalle);
            }
        }
        //
        public IReadOnlyCollection<Descuento> ListarDescuentos()
        {
            try
            {
                return context.Descuento.Include(d => d.TipoCliente).ToList()
                    ;
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarDescuentos): " + detalle
                );
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
        //devuelve todos 
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

        public IReadOnlyCollection<Descuento> ListarDescuentosActivosPorTipoCliente(int tipoClienteId)
        {
            try
            {
                return context.Descuento
                    .Where(d =>
                        d.Activo &&
                        d.TipoClienteId == tipoClienteId)
                    .OrderBy(d => d.Nombre)
                    .ToList();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en RepositorioDescuento.ListarDescuentosActivosPorTipoCliente(): "
                    + detalle
                );
            }
        }
    }
}
