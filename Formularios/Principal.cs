using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void convocadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarAlumnos_Click(object sender, EventArgs e)
        {
            regAlumnos agregar = new regAlumnos();
            agregar.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void primeraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tablaEstadistica estadisticas = new tablaEstadistica();
            estadisticas.Show();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regCuotas cs = new regCuotas();
            cs.Show();
        }

        private void Cuotas_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarPartidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroPartido vs = new registroPartido();
            vs.Show();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

                regAgenda ag = new regAgenda();
                ag.Show();
            
        }

        private void AgregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regAbono vn = new regAbono();
            vn.Show();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regCategoria vn = new regCategoria();
            vn.Show();
        }
    }
}
