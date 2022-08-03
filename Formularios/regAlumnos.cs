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
    public partial class regAlumnos : Form
    {
        private string cadenaConexion { get; set; }
        public regAlumnos()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
        }

        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");
        private DataSet ds;



        private void CargarGrilla()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("MostrarAlumno", conexion);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            conexion.Close();

            grillaAlumnos.DataSource = tabla;
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
        private int DevolverIndexCombo(string nombreTabla,string value, string descripcion, string pk)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            string consulta = "SELECT " + pk +  " FROM " + nombreTabla + " WHERE "+ descripcion + " = '" + value + "'";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            cmd.Connection = cn;
            cn.Open();
            int codigo = (int)cmd.ExecuteScalar();
            cn.Close();
            return codigo;


        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            String Sexo = "";
            if (radioM.Checked) Sexo = "Masculino";
            if (radioF.Checked) Sexo = "Femenino";


            Entidades.Alumno alumno = new Entidades.Alumno
            {
                Apellido = txtApellido.Text,
                Calle = txtCalle.Text,
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                Sexo = Sexo,
                IdtipoDocumento = txtTipoDoc.SelectedValue.ToString(),
                Nombre = txtNombre.Text,
                NroCalle = txtNroCalle.Text,
                NroDocumento = txtNroDoc.Text,
                IdCategoria = txtCategoria.SelectedValue.ToString(),
                Barrio = txtBarrio.Text,
                FechaAlta = DateTime.Parse(txtAlta.Text),
                FechaBaja = DateTime.Parse(txtBaja.Text),
                IdSocio = txtTipoSocio.SelectedValue.ToString(),
                Piso = txtPiso.Text,
                Depto = txtDepto.Text,
                IdEstado = txtEstado.SelectedValue.ToString()
            };

            bool resulado = InsertarNuevoAlumno(alumno);

            if (resulado == true)
            {
                MessageBox.Show("Se cargó el nuevo alumno");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar el nuevo alumno");
            }


        }

        private bool InsertarNuevoAlumno(Entidades.Alumno alumno)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarAlumno", cn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@fecha", alumno.FechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.Parameters.AddWithValue("@codTipoDoc", alumno.IdtipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", alumno.NroDocumento);
                cmd.Parameters.AddWithValue("@calle", alumno.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", alumno.NroCalle);
                cmd.Parameters.AddWithValue("@piso", alumno.Piso);
                cmd.Parameters.AddWithValue("@depto", alumno.Depto);
                cmd.Parameters.AddWithValue("@Barrio", alumno.Barrio);
                cmd.Parameters.AddWithValue("@codCategoria", alumno.IdCategoria);
                cmd.Parameters.AddWithValue("@codEstado", alumno.IdEstado);
                cmd.Parameters.AddWithValue("@fechaAlta", alumno.FechaAlta);
                cmd.Parameters.AddWithValue("@FechaBaja", alumno.FechaBaja);
                cmd.Parameters.AddWithValue("@codTipoSocio", alumno.IdSocio);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
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
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String Sexo = "";
            if (radioM.Checked) Sexo = "Masculino";
            if (radioF.Checked) Sexo = "Femenino";


            Entidades.Alumno alumno = new Entidades.Alumno
            {
                Apellido = txtApellido.Text,
                Calle = txtCalle.Text,
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                Sexo = Sexo,
                IdtipoDocumento = txtTipoDoc.SelectedValue.ToString(),
                Nombre = txtNombre.Text,
                NroCalle = txtNroCalle.Text,
                NroDocumento = txtNroDoc.Text,
                IdCategoria = txtCategoria.SelectedValue.ToString(),
                Barrio = txtBarrio.Text,
                FechaAlta = DateTime.Parse(txtAlta.Text),
                FechaBaja = DateTime.Parse(txtBaja.Text),
                IdSocio = txtTipoSocio.SelectedValue.ToString(),
                Piso = txtPiso.Text,
                Depto = txtDepto.Text,
                IdEstado = txtEstado.SelectedValue.ToString()
            };

            bool resulado = ActualizarAlumno(alumno);

            if (resulado)
            {
                CargarGrilla();
                MessageBox.Show("Se actualizo el alumno");
            }
            else MessageBox.Show("Error al actualiar el alumno");
        }
        private bool ActualizarAlumno(Entidades.Alumno alumno)
        {
            if (alumno.Nombre == "")
            {
                MessageBox.Show("Falta completar el campo Nombre");
                return false;
            }
            if (alumno.Apellido == "")
            {
                MessageBox.Show("Falta completar el campo Apellido");
                return false;
            }

            if (Convert.ToString(alumno.NroDocumento) == "")
            {
                MessageBox.Show("Falta completar el campo Nro. Documento");
                return false;
            }


            if (Convert.ToString(alumno.FechaNacimiento) == "")
            {
                MessageBox.Show("Falta completar el campo Fecha Nacimiento");
                return false;
            }

            if (Convert.ToString(alumno.FechaAlta) == "")
            {
                MessageBox.Show("Falta completar el campo Fecha Alta");
                return false;
            }

            if (alumno.Calle == "")
            {
                MessageBox.Show("Falta completar el campo Calle");
                return false;
            }
            if (Convert.ToString(alumno.NroCalle) == "")
            {
                MessageBox.Show("Falta completar el campo Numero de calle");
                return false;
            }
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand("ActualizarAlumno", cn);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@fecha", alumno.FechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.Parameters.AddWithValue("@codTipoDoc", alumno.IdtipoDocumento);
                cmd.Parameters.AddWithValue("@nroDoc", alumno.NroDocumento);
                cmd.Parameters.AddWithValue("@calle", alumno.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", alumno.NroCalle);
                cmd.Parameters.AddWithValue("@piso", alumno.Piso);
                cmd.Parameters.AddWithValue("@depto", alumno.Depto);
                cmd.Parameters.AddWithValue("@Barrio", alumno.Barrio);
                cmd.Parameters.AddWithValue("@codCategoria", alumno.IdCategoria);
                cmd.Parameters.AddWithValue("@codEstado", alumno.IdEstado);
                cmd.Parameters.AddWithValue("@fechaAlta", alumno.FechaAlta);
                cmd.Parameters.AddWithValue("@FechaBaja", alumno.FechaBaja);
                cmd.Parameters.AddWithValue("@codTipoSocio", alumno.IdSocio);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grillaAlumnos.DataSource = BuscarAlumno();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(txtNroDoc.Text);
            if (EliminarAlumno(dni))
            {
                MessageBox.Show("Se elimino el alumno");
            }
            else MessageBox.Show("No se pudo eliminar el alumno");
            CargarGrilla();
        }
        public DataTable BuscarAlumno()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM alumno WHERE nroDoc LIKE '%" + this.txtBuscar.Text + "%'";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];

        }
        private bool EliminarAlumno(int dni)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {                
            SqlCommand cmd = new SqlCommand();
            string consulta = "DELETE FROM alumno WHERE nroDoc = @NroDoc";
            cmd.Parameters.AddWithValue("@NroDoc", dni);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;
            int filasAfectadas = cmd.ExecuteNonQuery();
            cn.Close();

            if (filasAfectadas > 0) return true;

            else return true;
            }
            catch(SqlException ex)
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



        private void RegAlumnos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            grillaAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarCombo(ref this.txtBarrio, "Barrio", "nombre", "cod_barrio");
            CargarCombo(ref this.txtTipoDoc, "TipoDoc", "descripcion", "cod_tipoDoc");
            CargarCombo(ref this.txtCategoria, "Categoria", "descripcion", "cod_categoria");
            CargarCombo(ref this.txtEstado, "Estado", "nombre", "cod_estado");
            CargarCombo(ref this.txtTipoSocio, "TipoSocio", "descripcion", "cod_tipoSocio");

        }

        private void GrillaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = grillaAlumnos.Rows[e.RowIndex];
            txtNombre.Text = Convert.ToString(fila.Cells[0].Value);
            txtApellido.Text = Convert.ToString(fila.Cells[1].Value);
            txtTipoDoc.SelectedValue = DevolverIndexCombo("TipoDoc", Convert.ToString(fila.Cells[4].Value), "descripcion", "cod_tipoDoc");
            txtNroDoc.Text = Convert.ToString(fila.Cells[5].Value);
            txtCategoria.SelectedValue = DevolverIndexCombo("Categoria", Convert.ToString(fila.Cells[11].Value), "descripcion", "cod_categoria");
            txtCalle.Text = Convert.ToString(fila.Cells[6].Value);
            txtNroCalle.Text = Convert.ToString(fila.Cells[7].Value);
            txtPiso.Text = Convert.ToString(fila.Cells[8].Value);
            txtDepto.Text = Convert.ToString(fila.Cells[9].Value);
            txtBarrio.Text = Convert.ToString(fila.Cells[10].Value);
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            String Sexo = "";
            if (radioM.Checked) Sexo = "Masculino";
            if (radioF.Checked) Sexo = "Femenino";


            Entidades.Alumno alumno = new Entidades.Alumno
            {
                Apellido = txtApellido.Text,
                Calle = txtCalle.Text,
                FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                Sexo = Sexo,
                IdtipoDocumento = txtTipoDoc.SelectedValue.ToString(),
                Nombre = txtNombre.Text,
                NroCalle = txtNroCalle.Text,
                NroDocumento = txtNroDoc.Text,
                IdCategoria = txtCategoria.SelectedValue.ToString(),
                Barrio = txtBarrio.Text,
                FechaAlta = DateTime.Parse(txtAlta.Text),
                FechaBaja = DateTime.Parse(txtBaja.Text),
                IdSocio = txtTipoSocio.SelectedValue.ToString(),
                Piso = txtPiso.Text,
                Depto = txtDepto.Text,
                IdEstado = txtEstado.SelectedValue.ToString()
            };

            bool resulado = ActualizarAlumno(alumno);

            if (resulado)
            {
                CargarGrilla();
                MessageBox.Show("Se actualizo el alumno");
            }
            else MessageBox.Show("Error al actualizar el alumno");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            grillaAlumnos.DataSource = BuscarAlumno();
        }

        private void TxtTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}