using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    [PrimaryKey(nameof(VentaId), nameof(ProductoId))] //clave compuesta
    public class DetalleVenta
    {
        public int VentaId { get; set; }
        
        public int ProductoId { get; set; }
        
        public int Cantidad { get; set; }
        public decimal Monto { get; set; }
        
        public Venta Venta { get; set; } //ref a una vta
        public Producto Producto { get; set; } //ref a un prod
        

    }
}
