using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto producto;
        private Comiqueria comiqueria;

        public VentasForm(Producto producto, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = producto;
            this.comiqueria = comiqueria;
            lblCantidad.Text = "Cantidad:";
            lblDescripcion.Text = producto.Descripcion;

            StringBuilder sb = new StringBuilder();
            lblPrecioFinal.Text = sb.AppendFormat("Precio Final: ${0}", producto.Precio).ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(numericUpDownCantidad.Value > producto.Stock)
            {
                MessageBox.Show("Supero el stock disponible.\nDisminuya la cantidad a vender.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                DialogResult = DialogResult.OK;
            }
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            lblPrecioFinal.Text = sb.AppendFormat("Precio Final: ${0}", producto.Precio * (int)numericUpDownCantidad.Value).ToString();
        }
    }
}
