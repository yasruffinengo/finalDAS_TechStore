using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
    public enum TipoCliente
    {
        Mayorista,
        Minorista
    } */
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string NumeroDocumento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        //public TipoCliente TipoDeCliente { get; set; }

        public bool Activo { get; set; } = true;

        [NotMapped]
        public string Estado
        {
            get
            {
                return Activo ? "Activo" : "Inactivo";
            }
        }


        //navegacion: el cliente tiene muchas ventas.
        public ICollection<Venta> Ventas { get; set; } = new List<Venta>();

        // FK hacia TipoCliente
        public int TipoClienteId { get; set; }

        // Navegación: cada cliente tiene un tipo
        public TipoCliente TipoCliente { get; set; }

    }
}
