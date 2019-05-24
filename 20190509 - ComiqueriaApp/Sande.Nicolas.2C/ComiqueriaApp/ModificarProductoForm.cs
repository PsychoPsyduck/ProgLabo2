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
    public partial class ModificarProductoForm : Form
    {
        private Producto producto;

        public ModificarProductoForm(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            txtPrecioActual.Text = producto.Precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            double cambio;
            if(double.TryParse(txtNuevoPrecio.ToString(), out cambio))
            {
                DialogResult result = MessageBox.Show("Desea confirmar la modificacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    producto.Precio = cambio;
                    lblError.Text = "";
                }
            }
            else
            {
                lblError.Text = "Error. Debe ingresar un precio valido";
            }
        }
    }
}
