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
    public partial class Ejercicio4Form : Form
    {
        public Ejercicio4Form()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            ArticuloTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            PrecioCompraTextBox.Text = string.Empty;
            PrecioVentaTextBox.Text = string.Empty;
            DescripcionRichTextBox.Text = string.Empty;
        }
        private void Ejercicio4Form_Load(object sender, EventArgs e)
        {
            
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Tienda tienda = new Tienda();

            tienda.articulo = ArticuloTextBox.Text;
            tienda.cantidad = Convert.ToInt32(CantidadTextBox.Text);
            tienda.descripcion = DescripcionRichTextBox.Text;
            tienda.precioCompra = Convert.ToDecimal(PrecioCompraTextBox.Text);
            tienda.precioVenta = Convert.ToDecimal(PrecioVentaTextBox.Text);

            limpiar();
        }
    }
}
