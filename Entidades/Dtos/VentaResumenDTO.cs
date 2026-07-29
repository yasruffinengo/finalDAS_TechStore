namespace Entidades.DTOs
{
    public class VentaResumenDTO
    {
        public int VentaId { get; set; }
        public int NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string Sucursal { get; set; } = string.Empty;
        public string Vendedor { get; set; } = string.Empty;
        public string MetodoPago { get; set; } = string.Empty;
        public decimal MontoSubtotal { get; set; }
        public decimal MontoDescuento { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
