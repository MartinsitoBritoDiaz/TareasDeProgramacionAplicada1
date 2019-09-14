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
    public partial class Ejercicio7Form : Form
    {
        public Ejercicio7Form()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            float cantidadLados;
            float longituLados;
            float apotema;

            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(CantidadLadosTextBox.Text))
            {
                MyErrorProvider.SetError(CantidadLadosTextBox, "El campo cantidad de lados no puede estar vacio");
                CantidadLadosTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(LongitudLadosTextBox.Text))
            {
                MyErrorProvider.SetError(LongitudLadosTextBox, "El campo longitud de lados no puede estar vacio");
                LongitudLadosTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ApotemaTextBox.Text))
            {
                MyErrorProvider.SetError(ApotemaTextBox, "El campo Apotema no puede estar vacio");
                ApotemaTextBox.Focus();
                paso = false;
            }

            cantidadLados = Convert.ToSingle(CantidadLadosTextBox.Text);
            longituLados = Convert.ToSingle(LongitudLadosTextBox.Text);
            apotema = Convert.ToSingle(ApotemaTextBox.Text);

            if (cantidadLados < 0)
            {
                MyErrorProvider.SetError(CantidadLadosTextBox, "El campo cantidad de lados no puede ser menor a 3");
                CantidadLadosTextBox.Focus();
                paso = false;
            }

            if(longituLados < 0)
            {
                MyErrorProvider.SetError(LongitudLadosTextBox, "El campo longitud de lados no puede ser menor a 1");
                LongitudLadosTextBox.Focus();
                paso = false;
            }

            if(apotema < 0)
            {
                MyErrorProvider.SetError(ApotemaTextBox, "El campo Apotema no puede ser menor a 0");
                ApotemaTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private void AreaButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
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

        private void PerimetroButton_Click_1(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            float cantidadLados;
            float longituLados;
            cantidadLados = Convert.ToSingle(CantidadLadosTextBox.Text);
            longituLados = Convert.ToSingle(LongitudLadosTextBox.Text);
            PerimetroTextBox.Text = Convert.ToString(cantidadLados * longituLados);
        }

        private void Ejercicio7Form_Load(object sender, EventArgs e)
        {

        }
    }
}
