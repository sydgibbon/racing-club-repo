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
    public partial class regCategoria : Form
    {
        private string cadenaConexion { get; set; }

        public regCategoria()
        {
            InitializeComponent();
            cadenaConexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
        }
        private DataSet ds;
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True");

        public DataTable mostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categoria", conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        private void CargarGrilla()
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenaConexion);

            string consulta = "SELECT * FROM Categoria";
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            DataTable tabla = new DataTable();
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            cn.Close();

            grillaCategorias.DataSource = tabla;
        }

        private void regCategoria_Load(object sender, EventArgs e)
        {
            grillaCategorias.DataSource = mostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidadAlumnos = int.Parse(txtCantidad.Text);
            string rangoEdad = txtRango.Text;
            string nombre = txtNombre.Text;

            Entidades.Categorias categoria = new Entidades.Categorias
            {
                CantidadAlumnos = cantidadAlumnos,
                RangoEdad = rangoEdad,
                Nombre = nombre
            };

            bool resulado = InsertarCategoria(categoria);

            if (resulado == true)
            {
                MessageBox.Show("Se cargó la nueva Categoria");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al agregar la Categoria");
            }
        }

        private bool InsertarCategoria(Entidades.Categorias categoria)
        {
            if (categoria.Nombre == "")
            {
                MessageBox.Show("Falta completar el campo Nombre");
                return false;
            }

            if (categoria.CantidadAlumnos == 0)
            {
                MessageBox.Show("Falta completar el campo Cantidad Alumnos");
                return false;
            }

            if (categoria.RangoEdad == "")
            {
                MessageBox.Show("Falta completar el campo Rango Edad");
                return false;
            }
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Categoria (descripcion, cantidadAlumnos, rangoEdad) VALUES (@nombre, @cantidadAlumnos, @rangoEdad)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@cantidadAlumnos", categoria.CantidadAlumnos);
                cmd.Parameters.AddWithValue("@rangoEdad", categoria.RangoEdad);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Seguro que quiere eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                if (txtNombre.Text == "") MessageBox.Show("Indique un nombre de categoria para eliminar");
                else
                {
                    string nombre = txtNombre.Text;
                    if (EliminarCategoria(nombre))
                    {
                        MessageBox.Show("Se elimino la Categoria");
                    }
                    else MessageBox.Show("No se pudo eliminar la Categoria");
                    grillaCategorias.DataSource = mostrarDatos();
                }
            }
        }

        private bool EliminarCategoria(string nombre)
        {
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Categoria WHERE descripcion = @Nombre";
                cmd.Parameters.AddWithValue("@Nombre", nombre);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int cantidadAlumnos = int.Parse(txtCantidad.Text);
            string rangoEdad = txtRango.Text;
            string nombre = txtNombre.Text;
            int cat = int.Parse(txtCategoria.Text);

            Entidades.Categorias categoria = new Entidades.Categorias
            {
                CantidadAlumnos = cantidadAlumnos,
                RangoEdad = rangoEdad,
                Nombre = nombre,
                Categoria = cat
            };

            bool resulado = ActualizarCategoria(categoria);

            if (resulado == true)
            {
                MessageBox.Show("Se Actualizó la Categoria");
                CargarGrilla();
            }
            else
            {
                MessageBox.Show("Error al Actualizar la Categoria");
            }
        }

        private bool ActualizarCategoria(Entidades.Categorias categoria)
        {
            if (categoria.Nombre == "")
            {
                MessageBox.Show("Falta completar el campo Nombre");
                return false;
            }

            if (categoria.CantidadAlumnos == 0)
            {
                MessageBox.Show("Falta completar el campo Cantidad Alumnos");
                return false;
            }

            if (categoria.RangoEdad == "")
            {
                MessageBox.Show("Falta completar el campo Rango Edad");
                return false;
            }

            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Categoria SET descripcion = @nombre, cantidadAlumnos = @cantidadAlumnos, rangoEdad = @rangoEdad WHERE cod_categoria = @categoria";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", categoria.Nombre);
                cmd.Parameters.AddWithValue("@cantidadAlumnos", categoria.CantidadAlumnos);
                cmd.Parameters.AddWithValue("@rangoEdad", categoria.RangoEdad);
                cmd.Parameters.AddWithValue("@categoria", categoria.Categoria);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            grillaCategorias.DataSource = BuscarCategoria();

        }

        public DataTable BuscarCategoria()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand();
            string consulta = "SELECT * FROM Categoria WHERE descripcion LIKE '%" + this.txtBuscar.Text + "%'";
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        private void grillaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow fila = grillaCategorias.Rows[e.RowIndex];
                txtCategoria.Text = Convert.ToString(fila.Cells[0].Value);
                txtNombre.Text = Convert.ToString(fila.Cells[1].Value);
                txtCantidad.Text = Convert.ToString(fila.Cells[2].Value);
                txtRango.Text = Convert.ToString(fila.Cells[3].Value);
            }
        }
    }
}
