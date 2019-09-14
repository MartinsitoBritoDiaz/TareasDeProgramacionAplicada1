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
    public partial class Ejercicio6Form : Form
    {
        public Ejercicio6Form()
        {
            InitializeComponent();
        }

        private void Ejercicio6Form_Load(object sender, EventArgs e)
        {

        }

        private void PerimetroButton_Click(object sender, EventArgs e)
        {
            float cantidadLados;
            float longituLados;
            cantidadLados = Convert.ToSingle(CantidadLadosTextBox.Text); 
            longituLados = Convert.ToSingle(LongitudLadosTextBox.Text);
            PerimetroTextBox.Text = Convert.ToString(cantidadLados * longituLados);
        }

        private void AreaButton_Click(object sender, EventArgs e)
        {
            float cantidadLados;
            float longituLados;
            float perimetro;
            float apotema;

            cantidadLados = Convert.ToSingle(CantidadLadosTextBox.Text);
            longituLados = Convert.ToSingle(LongitudLadosTextBox.Text);
            perimetro = cantidadLados * longituLados;
            apotema = Convert.ToSingle(ApotemaTextBox.Text);

            AreaTextBox.Text = Convert.ToString((perimetro * apotema) / 2);
        }

    }
}
