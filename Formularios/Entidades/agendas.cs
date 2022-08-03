using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Entidades
{
    class agendas
    {
        public string horario { get; set; }
        public int nroDoc { get; set; }
        public DateTime fecha { get; set; }
        public int tipoDoc { get; set; }
        public bool asistencia { get; set; }
    }
}

