using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //para mostrar el nombre de la categoria en grilla productos
        public override string ToString()
        {
            return Nombre;
        }
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
