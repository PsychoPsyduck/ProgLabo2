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
    public partial class FrmMostrar : Form
    {
        private Centralita central;

        public FrmMostrar(Centralita central)
        {
            InitializeComponent();

            this.central = central;
            //richTextBox1.Text = central.ToString();
        }
    }
}
