using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        //para mostrar el nombre en la grilla de vendedores / Inventario
        public override string ToString()
        {
            return Nombre;
        }
        //para mostrar Estado en la grilla
        [NotMapped]
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }
        
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
        public ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

    }
}
