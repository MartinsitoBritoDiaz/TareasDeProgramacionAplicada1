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
    public partial class Ejercicio1Form : Form
    {

        public struct Tienda
        {
            public string articulo;
            public decimal precio;
            public string cantidad;
        }
        
        public Ejercicio1Form()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            ArticuloTextBox.Text = string.Empty;
            PrecioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Tienda tienda;

            tienda.articulo = ArticuloTextBox.Text;
            tienda.precio = Convert.ToDecimal(PrecioTextBox.Text);
            tienda.cantidad = CantidadTextBox.Text;

            limpiar();

            MyDataGridView.Rows.Add(tienda.articulo, tienda.precio, tienda.cantidad);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
