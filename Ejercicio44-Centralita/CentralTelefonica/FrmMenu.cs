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
    public partial class FrmMenu : Form
    {
        private Centralita central;

        public FrmMenu()
        {
            InitializeComponent();
            central = new Centralita();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmLlamador = new FrmLlamador(central);
            DialogResult result = frmLlamador.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            Form frmMostrar = new FrmMostrar(central);
            DialogResult result = frmMostrar.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            Form frmMostrar = new FrmMostrar(central);
            DialogResult result = frmMostrar.ShowDialog();
        }

        private void btnFacturacionProv_Click(object sender, EventArgs e)
        {
            Form frmMostrar = new FrmMostrar(central);
            DialogResult result = frmMostrar.ShowDialog();
        }
    }
}
