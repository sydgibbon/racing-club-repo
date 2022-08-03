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
    public partial class registroPartido : Form
    {
        private string cadenaConexion { get; set; }

        public registroPartido()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";

        }
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");
        private DataSet ds;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CargarGrilla()
        {

            SqlConnection cn = new SqlConnection(cadenaConexion);
            cn.Open();
            SqlCommand cmd = new SqlCommand("MostrarPartido", cn);

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());

            cn.Close();

            dataPartido.DataSource = tabla;


        }

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
        private void RegPartido_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarCombo(ref this.txtCategoria, "Categoria", "descripcion", "cod_categoria");
            dataPartido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Entidades.Partido partido = new Entidades.Partido
            {
                FechaPartido = DateTime.Parse(txtFechaPartido.Text),
                Hora = txtHora.Text,
                Rival = txtRival.Text,
                Liga = txtLiga.Text,
                Categoria = txtCategoria.SelectedValue.ToString()
            };
            bool resulado = InsertarPartido(partido);

            if (resulado == true)
            {
                MessageBox.Show("Se cargó el nuevo partido.");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar el nuevo partido.");
            }
        }


        private bool InsertarPartido(Entidades.Partido partido)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Partido (fecha, hora, rival, liga, cod_categoria)" +
                    " VALUES (@Fecha, @Hora, @Rival, @Liga, @Categoria)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Fecha", partido.FechaPartido);
                cmd.Parameters.AddWithValue("@Hora", partido.Hora);
                cmd.Parameters.AddWithValue("@Rival", partido.Rival);
                cmd.Parameters.AddWithValue("@Liga", partido.Liga);
                cmd.Parameters.AddWithValue("@Categoria", partido.Categoria);
     
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
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        private void DataPartido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow fila = dataPartido.Rows[e.RowIndex];
                txtPartido.Text = Convert.ToString(fila.Cells[0].Value);
                txtFechaPartido.Text = Convert.ToString(fila.Cells[1].Value);
                txtHora.Text = Convert.ToString(fila.Cells[2].Value);
                txtRival.Text = Convert.ToString(fila.Cells[3].Value);
                txtLiga.Text = Convert.ToString(fila.Cells[4].Value);
                txtCategoria.Text = Convert.ToString(fila.Cells[5].Value);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int codPartido = int.Parse(txtPartido.Text);
            if (EliminarPartido(codPartido))
            {
                MessageBox.Show("Se elimino el alumno");
            }
            else MessageBox.Show("No se pudo eliminar el alumno");
            CargarGrilla();

        }
        private bool EliminarPartido(int codPartido)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Partido WHERE cod_partido = @CodPartido";
                cmd.Parameters.AddWithValue("@CodPartido", codPartido);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
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
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Entidades.Partido partido = new Entidades.Partido
            {
                CodPartido = txtPartido.Text,
                FechaPartido = DateTime.Parse(txtFechaPartido.Text),
                Hora = txtHora.Text,
                Rival = txtRival.Text,
                Liga = txtLiga.Text,
                Categoria = txtCategoria.SelectedValue.ToString()

            };
            bool resulado = ActualizarPartido(partido);

            if (resulado == true)
            {
                MessageBox.Show("Se actualizó el nuevo partido.");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al actualizar el nuevo partido.");
            }
            CargarGrilla();
        }
        private bool ActualizarPartido(Entidades.Partido partido)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Partido SET fecha = @Fecha, hora = @Hora, rival = @Rival, liga = @Liga, cod_categoria = @Categoria WHERE cod_partido = @CodPartido";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodPartido", partido.CodPartido);
                cmd.Parameters.AddWithValue("@Fecha", partido.FechaPartido);
                cmd.Parameters.AddWithValue("@Hora", partido.Hora);
                cmd.Parameters.AddWithValue("@Rival", partido.Rival);
                cmd.Parameters.AddWithValue("@Liga", partido.Liga);
                cmd.Parameters.AddWithValue("@Categoria", partido.Categoria);

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
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cn.Close();
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "") CargarGrilla();
            else
            {
                dataPartido.DataSource = BuscarPartido();
            }

        }
        public DataTable BuscarPartido()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Partido WHERE cod_partido LIKE '%" + this.txtBuscar.Text + "%'";
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

        private void TxtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void TxtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar (Codigo de partido)";
                CargarGrilla();
            }
        }


    }   
}
