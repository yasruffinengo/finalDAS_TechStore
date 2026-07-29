using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Dtos
{

        public class ProductoMasVendidoDTO
        {
            public int IdProducto { get; set; }

            public string NombreProducto { get; set; }

            public int CantidadVendida { get; set; }

            public decimal TotalVendido { get; set; }
        
    }
}
