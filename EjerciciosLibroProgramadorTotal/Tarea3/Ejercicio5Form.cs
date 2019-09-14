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
    public partial class Ejercicio5Form : Form
    {
        public Ejercicio5Form()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            NombreTextBox.Text = string.Empty;
            EdadTextBox.Text = string.Empty;
            CursoTextBox.Text = string.Empty;
            NumeroTextBox.Text = string.Empty;
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.nombre = NombreTextBox.Text;
            estudiantes.edad = Convert.ToInt32(EdadTextBox.Text);
            estudiantes.curso = CursoTextBox.Text;
            estudiantes.numero = Convert.ToInt32(NumeroTextBox.Text);

            limpiar();
        }
    }
}
