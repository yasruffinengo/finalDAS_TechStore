using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Factura
    {
        public enum TipoComprobante
        {
            FacturaA,
            FacturaB,
            FacturaC,
            NotaCredito,
            NotaDebito
        } 
        public enum TipoDocumento
        {
            CUIT,
            CUIL,
            CDI,
            LE,
            LC,
            DNI
        }

        [Key]
        public int FacturaId {  get; set; }
        public long NumeroCAE { get; set; } //lo saque como PK alv
        public DateTime FechaVencimientoCAE { get; set; }
        public int NumeroComprobante { get; set; }
        public DateTime FechaComprobante { get; set; }
        public TipoComprobante TipoDeComprobante { get; set; } 
        public string Concepto { get; set; } 
        public TipoDocumento TipoDeDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal ImporteNeto { get; set; }
        public decimal ImporteOperacionesExentas { get; set; }
        public decimal ImporteTotal { get; set; }
        public decimal ImporteTotalNoGravado { get; set; }
        public decimal ImporteTributos { get; set; }
        //public int idMoneda { get; set; } 
        //public decimal CotizacionMoneda { get; set; }
        public int PuntoVenta { get; set; }
        public string DetalleIVA { get; set; } 
        public string EndPointQR { get; set; }

        public int VentaId { get; set; } //fk
        public Venta Venta { get; set; } 


    }
}
