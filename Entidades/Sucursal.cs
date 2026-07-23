using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Sucursal
    {
        public int SucursalId { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; } = true;
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
        public ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

    }
}
