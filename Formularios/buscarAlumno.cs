using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class buscarAlumno : Form
    {

        private string cadenaConexion { get; set; }


        public buscarAlumno()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
            CargarGrilla();
            dataAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            regAlumnos vn = new regAlumnos();
            vn.Show();
            this.Hide();
        }



        private void BtnBusc_Click(object sender, EventArgs e)
        {
            string searchValue = txtBusqueda.Text;
            dataAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataAlumnos.Rows)
                {
                    if (row.IsNewRow)
                        continue;
                    string tabla1 = row.Cells[3].Value.ToString();
                    string tabla2 = row.Cells[4].Value.ToString();
                    if (tabla1.Equals(searchValue) || tabla2.Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void DataAlumnos_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSeleccionar_Click(this, new EventArgs());
        }

        private void DataAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewRow row = Entidades.intRow.getRow();


        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataAlumnos.CurrentRow;
            regCuotas vn = new regCuotas();
            vn.txtNom.Text = row.Cells["Nombre"].Value.ToString();
            vn.txtAp.Text = row.Cells["Apellido"].Value.ToString();
            vn.txtDoc.Text = row.Cells["Documento"].Value.ToString();
            vn.cmbDoc.DisplayMember = row.Cells["Tipo Doc."].Value.ToString();
            vn.Show();
            this.Hide();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "") CargarGrilla();
            else
            {
                dataAlumnos.DataSource = BuscarPartido();
            }
        }

        public DataTable BuscarPartido()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM alumno WHERE nombre LIKE '%" + this.txtBusqueda.Text + "%' OR apellido LIKE '%" + this.txtBusqueda.Text + "%'";
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            DataTable tabla = new DataTable();
            cmd.Connection = conexion;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();
            return tabla;
        }
        private void DataAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarGrilla()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            SqlCommand cmd = new SqlCommand("MostrarAlumno", conexion);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            dataAlumnos.DataSource = tabla;
        }
    }
}