using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Entidades.DTOs
    {
        public class ReporteVentaDTO
        {
            public int IdVenta { get; set; }

            public DateTime Fecha { get; set; }

            public string Producto { get; set; }

            public string Cliente { get; set; }

            public string Sucursal { get; set; }

            public string Vendedor { get; set; }

            public int Cantidad { get; set; }

            public decimal Subtotal { get; set; }
        }
    }

