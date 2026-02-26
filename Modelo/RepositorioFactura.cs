using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioFactura
    {
        private Context context;

        public RepositorioFactura()
        {
            context = new Context();
        }
    }
}
