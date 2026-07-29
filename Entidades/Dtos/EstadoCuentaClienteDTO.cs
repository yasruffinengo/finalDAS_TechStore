using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DTOs
{
    public class EstadoCuentaClienteDTO
    {
        public int IdCliente { get; set; }

        public string Cliente { get; set; } = string.Empty;

        public decimal TotalCompras { get; set; }

        public decimal TotalPagado { get; set; }

        public decimal SaldoPendiente { get; set; }
    }
}
