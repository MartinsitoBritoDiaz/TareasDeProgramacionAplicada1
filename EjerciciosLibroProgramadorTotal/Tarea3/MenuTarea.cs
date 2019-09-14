using EjerciciosLibroProgramadorTotal.Tarea3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroProgramadorTotal
{
    public partial class MenuTarea : Form
    {
        public MenuTarea()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void EjerciciosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
        }
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Capitulo9ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ProductosDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1Form ejercicio = new Ejercicio1Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void InformacionDeMascotaYSuDueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio2Form ejercicio = new Ejercicio2Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void TiposDeNeumaticosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ejercicio3Form ejercicio = new Ejercicio3Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void InventarioDeUnaTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio4Form ejercicio = new Ejercicio4Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void EstudiantesDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio5Form ejercicio = new Ejercicio5Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void PoligonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio6Form ejercicio = new Ejercicio6Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void PropiedadesAPoligonosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio7Form ejercicio = new Ejercicio7Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }

        private void DepurarFactorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio8Form ejercicio = new Ejercicio8Form();
            ejercicio.MdiParent = this;
            ejercicio.Show();
        }
    }
}
