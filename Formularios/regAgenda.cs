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
    public partial class regAgenda : Form
    {
        private string cadenaConexion { get; set; }

        public regAgenda()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
            grillaAgendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarCombo(ref this.txtTipoDoc, "TipoDoc", "descripcion", "cod_tipoDoc");

        }

        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");


        private void regAgenda_Load(object sender, EventArgs e)
        {
            grillaAgendas.DataSource = mostrarDatos();
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


        public DataTable mostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Agenda", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int tipoDoc = 0;
            if (txtTipoDoc.Text == "DNI") tipoDoc = 1;
            if (txtTipoDoc.Text == "Pasaporte") tipoDoc = 2;
            if (txtTipoDoc.Text == "Libreta Civica") tipoDoc = 3;

            string horario = txtHorario.Text;
            int nroDoc = int.Parse(txtNroDoc.Text);

            bool asistencia = false;
            if (rbPresente.Checked) asistencia = true;
            if (rbAusente.Checked) asistencia = false;

            Entidades.agendas agenda = new Entidades.agendas
            {
                horario = horario,
                nroDoc = nroDoc,
                tipoDoc = tipoDoc,
                asistencia = asistencia,
                fecha = DateTime.Parse(txtFecha.Text)

            };

            bool resultado = registrarAgenda(agenda);
            if (resultado)
            {
                MessageBox.Show("Se Registró la Agenda");
                grillaAgendas.DataSource = mostrarDatos();
            }
            else MessageBox.Show("No se pudo Registrar la Agenda");

        }

        private bool registrarAgenda(Entidades.agendas agenda)
        {
            if (agenda.tipoDoc == 0)
            {
                MessageBox.Show("Falta completar el campo Tipo Documento");
                return false;
            }
            if (Convert.ToString(agenda.nroDoc) == "")
            {
                MessageBox.Show("Falta completar el campo Numero Documento");
                return false;
            }
            if (Convert.ToString(agenda.fecha) == "")
            {
                MessageBox.Show("Falta completar el campo Fecha");
                return false;
            }
            if (agenda.horario == "")
            {
                MessageBox.Show("Falta completar el campo Horario");
                return false;
            }

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Agenda (cod_tipoDoc, nroDoc, fecha, horario, presente) VALUES (@tipodoc, @nrodoc, @fecha, @horario, @presente)";
                cmd.Parameters.AddWithValue("@nrodoc", agenda.nroDoc);
                cmd.Parameters.AddWithValue("@tipodoc", agenda.tipoDoc);

                cmd.Parameters.AddWithValue("@fecha", agenda.fecha);
                cmd.Parameters.AddWithValue("@horario", agenda.horario);

                cmd.Parameters.AddWithValue("@presente", agenda.asistencia);


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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int tipoDoc = 0;
            if (txtTipoDoc.Text == "DNI") tipoDoc = 1;
            if (txtTipoDoc.Text == "Pasaporte") tipoDoc = 2;
            if (txtTipoDoc.Text == "Libreta Civica") tipoDoc = 3;

            string horario = txtHorario.Text;
            int nroDoc = int.Parse(txtNroDoc.Text);

            bool asistencia = false;
            if (rbPresente.Checked) asistencia = true;
            if (rbAusente.Checked) asistencia = false;

            Entidades.agendas agenda = new Entidades.agendas
            {
                horario = horario,
                nroDoc = nroDoc,
                tipoDoc = tipoDoc,
                asistencia = asistencia,
                fecha = DateTime.Parse(txtFecha.Text)

            };

            bool resultado = ActualizarAgenda(agenda);
            if (resultado)
            {
                MessageBox.Show("Se Actualizo la Agenda");
                grillaAgendas.DataSource = mostrarDatos();
            }
            else MessageBox.Show("No se pudo Actualizar la Agenda");
        }


        private bool ActualizarAgenda(Entidades.agendas agenda)
        {
            if (agenda.tipoDoc == 0)
            {
                MessageBox.Show("Falta completar el campo Tipo Documento");
                return false;
            }
            if (Convert.ToString(agenda.nroDoc) == "")
            {
                MessageBox.Show("Falta completar el campo Numero Documento");
                return false;
            }
            if (Convert.ToString(agenda.fecha) == "")
            {
                MessageBox.Show("Falta completar el campo Fecha");
                return false;
            }
            if (agenda.horario == "")
            {
                MessageBox.Show("Falta completar el campo Horario");
                return false;
            }

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Agenda SET cod_tipoDoc = @tipodoc, nroDoc = @nrodoc, fecha = @fecha, horario = @horario, presente = @presente";

                cmd.Parameters.AddWithValue("@nrodoc", agenda.nroDoc);
                cmd.Parameters.AddWithValue("@tipodoc", agenda.tipoDoc);
                cmd.Parameters.AddWithValue("@fecha", agenda.fecha);
                cmd.Parameters.AddWithValue("@horario", agenda.horario);
                cmd.Parameters.AddWithValue("@presente", agenda.asistencia);


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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que quiere eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (txtNroDoc.Text == "") MessageBox.Show("Indique un Numero de Documento para eliminar");
                else
                {
                    int dni = int.Parse(txtNroDoc.Text);
                    if (EliminarAlumno(dni))
                    {
                        MessageBox.Show("Se Elimino la Agenda");
                        grillaAgendas.DataSource = mostrarDatos();
                    }
                    else MessageBox.Show("No se pudo Eliminar la Agenda");
                }
            }
        }

        private bool EliminarAlumno(int dni)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Agenda WHERE nroDoc = @NroDoc";
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
            grillaAgendas.DataSource = BuscarAlumno();
        }

        public DataTable BuscarAlumno()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Agenda WHERE nroDoc LIKE '%" + this.txtBuscar.Text + "%'";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];

        }

        private void grillaAgendas_CellClick(object sender, DataGridViewCellEventArgs e)

        {   if (e.RowIndex > -1)
            {
                DataGridViewRow fila = grillaAgendas.Rows[e.RowIndex];
                txtTipoDoc.Text = Convert.ToString(fila.Cells[0].Value);
                txtNroDoc.Text = Convert.ToString(fila.Cells[1].Value);
                txtFecha.Text = Convert.ToString(fila.Cells[2].Value);
                txtHorario.Text = Convert.ToString(fila.Cells[3].Value);


                if (fila.Cells[4].Value != null) rbPresente.Checked = true;
                else rbAusente.Checked = true;
            }

        }
    }


}
