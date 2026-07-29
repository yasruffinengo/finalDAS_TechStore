using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal MontoSubtotal { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoTotal { get; set; }
        public int MetodoPagoId { get; set; }
        public bool Saldada { get; set; } = true;
        public DateTime? FechaSaldada { get; set; }
        //1aN navegacion. venta.detalle 
        public ICollection<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public MetodoPago MetodoPago { get; set; }
        //relaciono cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Factura? Factura { get; set; } //1a1
        //relaciono sucursal
        public int SucursalId { get; set; } 
        public Sucursal Sucursal { get; set; }

        //relaciono el desc con la venta
        public int? DescuentoId { get; set; }
        public Descuento? Descuento { get; set; }
        //relaciono con vendedor
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

    }
}
