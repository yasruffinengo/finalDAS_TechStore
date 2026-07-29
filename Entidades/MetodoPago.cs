using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoPago
    {
        public int MetodoPagoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; } = true;
        public bool EsCuentaCorriente { get; set; } = false;

        // un mp esta en muchas ventas:
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}
