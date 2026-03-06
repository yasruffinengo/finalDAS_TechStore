using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum TipoCliente
    {
        Mayorista,
        Minorista
    }
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string NumeroDocumento { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public TipoCliente TipoDeCliente { get; set; }

        public bool Activo { get; set; } = true;



    }
}
