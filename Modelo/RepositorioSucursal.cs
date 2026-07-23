using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioSucursal
    {
        private Context context;

        public RepositorioSucursal()
        {
            context = new Context();
        }

        public void AgregarSucursal(Sucursal sucursal)
        {
            try
            {
                context.Sucursal.Add(sucursal);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarSucursal(): " + detalle);
            }
        }

        public void ModificarSucursal(Sucursal sucursal)
        {
            try
            {
                context.Sucursal.Update(sucursal);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarSucursal(): " + detalle);
            }
        }
        /* NO SE USA.
        public void EliminarSucursal(Sucursal sucursal)
        {
            try
            {
                sucursal.Activo = false;
                context.Sucursal.Update(sucursal);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.EliminarSucursal(): " + detalle);
            }
        }*/
        public IReadOnlyCollection<Sucursal> ListarSucursalesActivas()
        {
            try
            {
                return context.Sucursal.Where(s => s.Activo == true).ToList().AsReadOnly();

            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarSucursalesActivas(): " + detalle);
            }
        }
        public IReadOnlyCollection<Sucursal> ListarSucursales()
        {

            try
            {
                return context.Sucursal
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarSucursales(): " + detalle
                );
            }

        }
        public Sucursal? ObtenerSucursalPorId(int idSucursal)
        {
            try
            {
                return context.Sucursal.Find(idSucursal);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerSucursalPorId(): " + detalle);
            }
        }
        public Sucursal? ObtenerSucursalPorNombre(string nombre)
        {
            try
            {
                return context.Sucursal
                    .FirstOrDefault(s => s.Nombre == nombre);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception("Error en Repositorio.ObtenerSucursalPorNombre(): " + detalle);
            }
        }
    }
}
