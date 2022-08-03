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
    public partial class regCuotas : Form
    {
        private string cadenaConexion { get; set; }

        public regCuotas()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
            grillaCuotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");

        private void CargarCombo(ref ComboBox combo, string nombreTabla, string descripcion, string pk)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            string consulta = "SELECT * FROM " + nombreTabla;
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            DataTable tabla = new DataTable();
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            cn.Close();

            combo.Items.Clear();
            combo.DataSource = tabla;

            combo.DisplayMember = descripcion;
            combo.ValueMember = pk;
        }

        private void Cuotas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCombo(ref this.cmbDoc, "TipoDoc","descripcion", "cod_tipoDoc");
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tipoDocTableAdapter.FillBy(this.pAV_RACINGDataSet1.TipoDoc);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void BtnRegistrar_Click(object sender, EventArgs e)

        {
            string estado = "";
            if (radioPagado.Checked) estado = "Pagado";
            else estado = "No Pagado";





            Entidades.Cuotas cuota = new Entidades.Cuotas
            {
                TipoDoc = cmbDoc.SelectedValue.ToString(),
                NroDoc = Convert.ToInt32(txtDoc.Text),
                Nombre = txtNom.Text,
                Apellido = txtAp.Text,
                Monto = txtMonto.Text,
                Estado = estado,
                Vencimiento = DateTime.Parse(fechaCuota.Text),
                FechaPago = DateTime.Now
            };

            bool resulado = RegistrarCuota(cuota);

            if (resulado == true)
            {
                MessageBox.Show("Se registró la cuota");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al registrar la cuota");
            }
        }
        private bool RegistrarCuota(Entidades.Cuotas cuota)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO AbonoXSocio (nroDoc, cod_tipoDoc, fechaVencimiento, fechaPago, monto, estado) VALUES (@nrodoc, @tipodoc, @fechaVencimiento, @fechaPago, @monto, @estado)";
                cmd.Parameters.AddWithValue("@nrodoc", cuota.NroDoc);
                cmd.Parameters.AddWithValue("@tipodoc", cuota.TipoDoc);

                cmd.Parameters.AddWithValue("@fechaVencimiento", cuota.Vencimiento);
                cmd.Parameters.AddWithValue("@fechaPago", cuota.FechaPago);

                cmd.Parameters.AddWithValue("@monto", cuota.Monto);

                cmd.Parameters.AddWithValue("@estado", cuota.Estado);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                StringBuilder errorMessages = new StringBuilder();
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
                buscarAlumno vn = new buscarAlumno();
                vn.Show();
                this.Hide();
            
        }

        private void CargarGrilla()
        {

            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("MostrarCuotas", cn);

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cn.Close();

            grillaCuotas.DataSource = tabla;


        }

        private void GrillaCuotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
