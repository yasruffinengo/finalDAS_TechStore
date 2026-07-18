using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Modelo
{
    public class RepositorioCategoria
    {
        private Context context;

        public RepositorioCategoria()
        {
            context = new Context();
        }

        //read
        public IReadOnlyCollection<Categoria> ListarCategorias()
        {
            try
            {
                return context.Categoria.ToList().AsReadOnly();
            }
            catch (Exception ex)
            {   

                throw new Exception("Error al listar las categorias: " + ex.Message);

            }
        }
     
        public void AgregarCategoria(Categoria categoria)
        {
            try
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
            }
            catch (Exception ex) {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.AgregarCategoria(): " + detalle);
            }
        }

        public void EliminarCategoria(Categoria categoria)
        {
            
                try
                {
                    context.Categoria.Remove(categoria);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    throw new Exception("Error en Repositorio.EliminarCategoria(): " + detalle);
                }
            
        }
        public void ModificarCategoria(Categoria categoria)
        {
            try
            {
                context.Categoria.Update(categoria);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ModificarCategoria(): " + detalle);
            }
        }

        public Categoria ObtenerCategoriaPorId(int id)
        {
            try
            {
                return context.Categoria.Find(id);
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception("Error en Repositorio.ObtenerCategoriaPorId(): " + detalle);
            }
        }

    }
}
