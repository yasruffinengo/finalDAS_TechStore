using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string Dni { get; set;}
        public bool Activo { get; set; } = true;
        //para que aparezca activo/inactivo en la grilla
        [NotMapped]
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }
        // relacion con sucursal
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }
        //relac con venta
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
