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
    public partial class login : Form
    {
        private String cadenaconexion;
        public login()
        {
            InitializeComponent();
            cadenaconexion = "Data Source=DESKTOP-M5FQ4H4\\SQLEXPRESS;Initial Catalog=PAV RACING;Integrated Security=True";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("") || txtpassword.Text.Equals(""))
            {
                MessageBox.Show("Ingrese nombre de usuario y contraseña");
            }
            else
            {
                string nombreDeUsuario = txtUser.Text.Trim();
                string password = txtpassword.Text.Trim();
                bool resultado = false;
                Entidades.Usuario usuario = new Entidades.Usuario();
                try
                {
                    resultado = ValidarUsuario(nombreDeUsuario, password);

                    if (resultado)
                    {
                        usuario.NombreDeUsuario = nombreDeUsuario;
                        usuario.Password = password;
                        usuario.FechaYHoraLogin = DateTime.Now;

                        Principal ventana = new Principal();
                        ventana.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar al sistema");
                }
            }
        }
        private bool ValidarUsuario(string NombreDeUsuario, string Password)
        {

            try
            {

                SqlCommand cmd = new SqlCommand();
                SqlConnection cn = new SqlConnection(cadenaconexion);

                string consulta = "SELECT * FROM usuario where usuario = @NombreUSu AND password = @Pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreUsu", NombreDeUsuario);
                cmd.Parameters.AddWithValue("@Pass", Password);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void TxtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(this, new EventArgs());
            }
        }
    }
}
