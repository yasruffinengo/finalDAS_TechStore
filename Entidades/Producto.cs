using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Codigo {get; set; }
        public string Descripcion { get; set; }
        public decimal MontoUnitario { get; set; }
        public bool Activo { get; set; } = true;
        
        //para mostrar columna estado en la grilla de productos
        [NotMapped] //no se migra a la bdd 
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }
        //para mostrar el nombre en la grilla Inventario
        public override string ToString()
        {
            return Nombre;
        }

        //descuento y categoria fk 
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        //navegacion. producto.detalle
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
        //p
        public ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();

    }
}
