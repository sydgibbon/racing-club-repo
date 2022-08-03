using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Entidades
{
    public class intRow
    {

        private static DataGridViewRow row;

        public static void setRow(DataGridViewRow row2)
        {
            row = row2;
        }

        public static DataGridViewRow getRow()
        {
            return row;
        }
    }
}
