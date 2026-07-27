using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoDescuento
    {
        Fijo,
        Porcentaje
    }
    
    public class Descuento
    {
        public int DescuentoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public decimal Valor { get; set; }
        public bool Activo { get; set; } = true;
        //para mostrar estado en la grilla
        [NotMapped]
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }
        public TipoDescuento TipoDeDescuento { get; set; } //enum para porcentaje o un monto
        //public TipoCliente TipoCliente { get; set; }    

        public int TipoClienteId { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();
    }
}

