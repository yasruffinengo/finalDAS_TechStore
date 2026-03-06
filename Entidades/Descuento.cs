using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
 {
    public enum TipoDescuento
    {
        MontoFijo,
        Porcentaje
    }

    public class Descuento
    {
        public int DescuentoId { get; set; }
        public string Nombre { get; set; }
        public int Valor { get; set; } 
        public bool Activo { get; set; }
        public TipoDescuento TipoDeDescuento { get; set; } //enum para porcentaje o un monto
        public TipoCliente TipoCliente { get; set; }    
    }
}

