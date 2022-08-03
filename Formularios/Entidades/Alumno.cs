using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios.Entidades
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string IdtipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Calle { get; set; }
        public string NroCalle { get; set; }
        public string Piso { get; set; }
        public string Depto { get; set; }
        public string Barrio { get; set; }
        public string IdCategoria { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string IdSocio { get; set;  }

        public string IdEstado { get; set; }


    }
}
