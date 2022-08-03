using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Entidades
{
    public class Cuotas
        {
        public string TipoDoc { get; set; }
        public int NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Vencimiento { get; set; }

        public DateTime FechaPago { get; set; }

        public string Monto { get; set; }
        public string Estado { get; set; }

    }
}
