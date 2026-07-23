using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Activo { get; set; } = true;
        // relacion con sucursal
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
        //relac con venta
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
