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
        public int numeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }
        public List<Producto> ListaProductos { get; set; }

        //cliente, metodo, detalleV y factura(1a1) fk 
        public int MetodoPagoId { get; set; }
        public ICollection<DetalleVenta> Detalles { get; set; } //1aN navegacion
        public MetodoPago MetodoPago { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public Factura Factura { get; set; } //1a1

        public int SucursalId { get; set; } 
        public Sucursal Sucursal { get; set; }

    }
}
