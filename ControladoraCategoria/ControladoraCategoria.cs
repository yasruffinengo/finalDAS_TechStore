using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// estaba Controladora
namespace ControladoraCategoria
{
    public class ControladoraCategoria
    {
        private RepositorioCategoria repositorio = new RepositorioCategoria();

        private static ControladoraCategoria instancia;

        private ControladoraCategoria()
        {

        }
        public static ControladoraCategoria Instancia
        {
            get
            {
                //si no esta creada la creo
                if (instancia == null)
                {
                    instancia = new ControladoraCategoria();
                }
                //si ya existe, devuelve esa
                return instancia;
            }
        }

        public string AgregarCategoria(Categoria categoria)
        {
            try
            {
                string validacion = ValidarCategoria(categoria);
                if (validacion != "OK")
                    return validacion;

                repositorio.AgregarCategoria(categoria);
                return "Categoria agregada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al agregar categoria: " + detalle;
            }
        }

        private string ValidarCategoria(Categoria categoria)
        {
            if (categoria == null)
                return "Error: La categoría no puede ser nula.";

            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                return "Error: El nombre de la categoría es obligatorio.";

            categoria.Nombre = categoria.Nombre.Trim();

            if (categoria.Nombre.Length < 3)
                return "Error: El nombre debe tener al menos 3 caracteres.";

            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                return "Error: La descripción es obligatoria.";

            categoria.Descripcion = categoria.Descripcion.Trim();

            if (categoria.Descripcion.Length < 5)
                return "Error: La descripción debe tener al menos 5 caracteres.";
            Categoria? categoriaExistente =
                repositorio.ObtenerCategoriaPorNombre(categoria.Nombre);

            if (categoriaExistente != null && categoriaExistente.CategoriaId != categoria.CategoriaId)
            {
                return "Error: Ya existe una categoría con ese nombre.";
            }

            return "OK";
        }
        public string ModificarCategoria(Categoria categoria)
        {
            try
            {
                string validacion = ValidarCategoria(categoria);
                if (validacion != "OK"){
                    return validacion;
                }

                repositorio.ModificarCategoria(categoria);
                return "Categoria modificada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al modificar categoria: " + detalle;
            }
        }
        
        public string EliminarCategoria(int idCategoria)
        {
            try
            {
                // Buscar cate antes de eliminar
                Categoria? categoria = repositorio.ObtenerCategoriaPorId(idCategoria);

                if (categoria == null)
                    return "Error: la categoria no existe o ya fue eliminada.";

                // Si existe, eliminar
                repositorio.EliminarCategoria(categoria);
                return "Categoria eliminada correctamente.";
            }
            catch (Exception ex)
            {
                string detalle = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                return "Error al eliminar categoria: " + detalle;
            }
        }

        public List<Categoria> ListarCategorias()
        {
            try
            {
                return repositorio.ListarCategorias().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar categorias" + ex.Message);
            }

        }
        public List<Categoria> ListarCategoriasActivas()
        {
            try
            {
                return repositorio.ListarCategorias().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("error al listar categorias" + ex.Message);
            }

        }

    }
}
