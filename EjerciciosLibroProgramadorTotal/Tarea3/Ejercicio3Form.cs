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
    public partial class Ejercicio3Form : Form
    {
        enum TiposNeumaticos
        {
           Invierno = 1,
           Asimétricos = 2,
           Tubuless = 3,
           Perfil_bajo = 4,
           Recauchutados = 5,
           Runflat = 6,
           Verdes = 7,
           Diagonal = 8,
           Direccionale = 9
        }
        public Ejercicio3Form()
        {
            InitializeComponent();
        }

        private void Ejercicio3Form_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TipoTextBox.Text = Enum.GetName(typeof(TiposNeumaticos), Convert.ToInt32(BuscarTextBox.Text));
        }
    }
}
