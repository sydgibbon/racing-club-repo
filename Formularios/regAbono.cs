using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Formularios
{
    public partial class regAbono : Form
    { private string cadenaConexion {get; set;}
        public regAbono()
        {
            InitializeComponent();
            panel.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
        }

        public bool agregar_tipo_abono(string descripcion)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO TipoAbono (descripcion) values (@desc)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                cn.Close();
            }

        }

        public bool modificar_tipo_abono(string descripcion, string cod_tipoabono)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE TipoAbono SET descripcion = @desc WHERE cod_TipoAbono = @cod";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@cod", cod_tipoabono);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                cn.Close();
            }

        }

        public bool eliminar_tipo_abono(string descripcion ,string codtA)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string comando = "DELETE FROM TipoAbono WHERE cod_TipoAbono = @cod ";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", descripcion);
                cmd.Parameters.AddWithValue("@cod", codtA);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = comando;

                cn.Open();
                cmd.Connection = cn;

                int fila = cmd.ExecuteNonQuery();

                if (fila > 0) return true;
                else return false;


            }
            catch (Exception er)
            {

                throw er;
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable obtener_abonos()

        {
            SqlConnection cn = new SqlConnection(cadenaConexion);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string comando = "SELECT * FROM TipoAbono";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = comando;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter ds = new SqlDataAdapter(cmd);
                ds.Fill(tabla);

                cmd.ExecuteNonQuery();

                return tabla;

            }
            catch (Exception er)
            {

                throw er;
            }
            finally
            {
                cn.Close();
            }
        }

        private void limpiar_campos()
        {
            txtdescripcion.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel.DataSource = obtener_abonos();
        }

        private void grillaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel.DataSource = obtener_abonos();
        }


        private void panel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow fila = panel.Rows[e.RowIndex];
                txtcod_tipoAbono.Text = Convert.ToString(fila.Cells[0].Value);
                txtdescripcion.Text = Convert.ToString(fila.Cells[1].Value);

            }

        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            if (txtdescripcion.Text.Equals(""))
            {
                MessageBox.Show("No se puede actualizar los datos... Debe completar los campos");

            }
            else
            {
                bool res = modificar_tipo_abono(txtdescripcion.Text.Trim(), txtcod_tipoAbono.Text);
                if (res)
                {
                    MessageBox.Show("Se Actualizo correctamnete los datos");
                    panel.DataSource = obtener_abonos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos.");
                    limpiar_campos();
                    txtdescripcion.Focus();
                    panel.DataSource = obtener_abonos();

                }
            }
        }

        private void Btnagregar_Click_1(object sender, EventArgs e)
        {
            if (txtdescripcion.Text.Equals("")) MessageBox.Show("Debe completar el campo");
            else
            {
                bool resultado = false;
                resultado = agregar_tipo_abono(txtdescripcion.Text.Trim());
                if (resultado)
                {
                    MessageBox.Show("Se agrego correctamente un nuevo Tipo de Abono");
                    limpiar_campos();
                    txtdescripcion.Focus();
                    panel.DataSource = obtener_abonos();

                }
            }
        }

        private void Btneliminar_Click_1(object sender, EventArgs e)
        {
            if (txtdescripcion.Text.Equals(""))
            {
                MessageBox.Show("Debe completar los campos para poder eliminar alumno");
            }
            else
            {
                bool resultado;
                resultado = eliminar_tipo_abono(txtdescripcion.Text.Trim(), txtcod_tipoAbono.Text.Trim());
                if (resultado) MessageBox.Show("Tipo de Abono eliminado con exito");

                else MessageBox.Show("No se pudo eliminar Tipo de Abono... Vuelva a intentalo");
                panel.DataSource = obtener_abonos();
            }
        }
    }
}
