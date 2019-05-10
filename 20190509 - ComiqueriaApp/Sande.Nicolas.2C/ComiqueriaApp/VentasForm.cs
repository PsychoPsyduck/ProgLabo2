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
        public VentasForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            ComiqueriaLogic.Producto p;
            if(numericUpDownCantidad.Value > 0)
            {
                MessageBox.Show("Supero el limite", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ComiqueriaLogic.Venta v;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
