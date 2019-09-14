using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    public partial class Ejercicio2Form : Form
    {
        public struct Mascota
        {
            public string nombreDueño;
            public string edadDueño;
            public string cedula;
            public string nombreMascota;
            public string edadMascota;
            public string raza;
        }
        public Ejercicio2Form()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            NombrePersTextBox.Text = string.Empty;
            NombreMasTextBox.Text = string.Empty;
            EdadMasTextBox.Text = string.Empty;
            EdadPersTextBox.Text = string.Empty;
            CedulaTextBox.Text = string.Empty;
            RazaTextBox.Text = string.Empty;
        }                     
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
         
        }

        private void NombreMasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Mascota mascota;

            mascota.nombreDueño = NombrePersTextBox.Text;
            mascota.nombreDueño = NombreMasTextBox.Text;
            mascota.edadMascota = EdadMasTextBox.Text;
            mascota.edadDueño = EdadPersTextBox.Text;
            mascota.cedula = CedulaTextBox.Text;
            mascota.raza = RazaTextBox.Text;

            limpiar();
            MyDataGridView.Rows.Add(mascota.nombreDueño, mascota.edadDueño, mascota.edadDueño, NombreMasTextBox.Text, mascota.edadMascota, mascota.raza);

        }
    }
}
