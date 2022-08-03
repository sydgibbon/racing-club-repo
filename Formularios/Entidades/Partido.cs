using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Entidades
{
    public class Partido
        {
        public string CodPartido { get; set; }
        public DateTime FechaPartido { get; set; }
        public string Hora { get; set; }
        public string Liga { get; set; }
        public string Rival { get; set; }
        public string Categoria { get; set; }
        }
}
