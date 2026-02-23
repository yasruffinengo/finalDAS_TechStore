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
        public string Descripcion { get; set; }
        public decimal MontoUnitario { get; set; }

        //descuento y categoria fk 
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public int DescuentoId { get; set; }
        public Descuento Descuento { get; set; }

        public ICollection<DetalleVenta> Detalles { get; set; } //navegacion 

    }
}
