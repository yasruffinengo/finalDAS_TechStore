using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoCliente
    {
        public int TipoClienteId { get; set; }
        public string Nombre { get; set; }
        //agregado para mostrarlo en la grilla de Descuento
        public override string ToString()
        {
            return Nombre;
        }

        // Navegación: un tipo puede corresponder a muchos clientes
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        // Navegación: un tipo puede tener muchos descuentos
        public ICollection<Descuento> Descuentos { get; set; } = new List<Descuento>();

    }
}
