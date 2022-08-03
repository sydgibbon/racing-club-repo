using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public class Validacion
        {
        public string ValidarRadio(bool radio1, bool radio2)
        {
            if (!radio1 & !radio2)
            {
                MessageBox.Show("Seleccione un estado!!");
            }
            if (radio1) return "Pagado";
            else return "No Pagado";


        }
        }
}
