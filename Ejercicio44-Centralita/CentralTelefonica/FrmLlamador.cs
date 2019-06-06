using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        private Centralita central;

        public FrmLlamador(Centralita central)
        {
            InitializeComponent();

            this.central = central;
        }

        public Centralita Central
        {
            get
            {
                return central;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
