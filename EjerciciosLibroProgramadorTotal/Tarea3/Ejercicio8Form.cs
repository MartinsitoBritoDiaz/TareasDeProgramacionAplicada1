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
    public partial class Ejercicio8Form : Form
    {
        public Ejercicio8Form()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int numero;

            numero = Convert.ToInt32(NumeroTextBox.Text);

            for (int i = numero - 1; i > 1; i--)
            {
                numero = numero * i;
                Console.WriteLine("{0}\n" , numero);
            }

            //Utilizar el metodo writeline para ver los cambios de la variable factorial cuando se ejecuta el debug.
            Console.WriteLine("\nEl factorial es: {0}", numero);

            FactorialTextBox.Text = Convert.ToString(numero);
        }

        private void Ejercicio8Form_Load(object sender, EventArgs e)
        {

        }
    }
}
