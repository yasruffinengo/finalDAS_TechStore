using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioVendedor
    {
        private Context context;

        public RepositorioVendedor()
        {
            context = new Context();
        }

        public void AgregarVendedor(Vendedor vendedor)
        {
            try
            {
                context.Vendedor.Add(vendedor);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarVendedor(): " + detalle);
            }
        }

        public void ModificarVendedor(Vendedor vendedor)
        {
            try
            {
                context.Vendedor.Update(vendedor);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarVendedor(): " + detalle);
            }
        }
        public IReadOnlyCollection<Vendedor> ListarVendedoresActivos()
        {
            try
            {
                return context.Vendedor.Where(v => v.Activo == true).ToList().AsReadOnly();

            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ListarVendedoresActivos(): " + detalle);
            }
        }
        public IReadOnlyCollection<Vendedor> ListarVendedores()
        {

            try
            {
                return context.Vendedor.Include(v => v.Sucursal)
                    .ToList()
                    .AsReadOnly();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null
                    ? ex.InnerException.Message
                    : ex.Message;

                throw new Exception(
                    "Error en Repositorio.ListarVendedores(): " + detalle
                );
            }

        }
        public Vendedor? ObtenerVendedorPorId(int idVendedor)
        {
            try
            {
                return context.Vendedor.Find(idVendedor);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerVendedorPorId(): " + detalle);
            }
        }

    }
}
