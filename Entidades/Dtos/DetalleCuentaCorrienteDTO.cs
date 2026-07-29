namespace Entidades.DTOs
{
    public class DetalleCuentaCorrienteDTO
    {
        public int VentaId { get; set; }
        public int NumeroVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Saldada { get; set; }
        public DateTime? FechaSaldada { get; set; }
        public string Estado => Saldada ? "Saldada" : "Pendiente";
    }
}
