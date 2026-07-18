using System;
using System.Collections.Generic;
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

        //descuento y categoria fk 
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        //navegacion. producto.detalle
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
        public ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
        /*
        public int DescuentoId { get; set; }
        public Descuento Descuento { get; set; }
        */



    }
}
