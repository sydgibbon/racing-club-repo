using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Entidades
{
    public class Usuario
    {
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaYHoraLogin { get; set; }
    }
}

