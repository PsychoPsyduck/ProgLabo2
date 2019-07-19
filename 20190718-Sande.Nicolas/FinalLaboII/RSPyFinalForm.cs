using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using EntidadesSPyFinal;
using Datos;
//using PP;

namespace FinalLaboII
{
    public partial class RSPyFinalForm : Form
    {
        public List<Transporte> listaTransportes;
        private List<Thread> hilos;

        public RSPyFinalForm()
        {
            InitializeComponent();
            this.listaTransportes = new List<Transporte>();
            hilos = new List<Thread>();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string aeroliena = txtAerolineaEmpresa.ToString();
            int velocidad = Convert.ToInt32(txtVelocidad.ToString());
            string fabricante = cmbFabricante.ToString();

            EFabricante fabricanteaux;
            if (fabricante == EFabricante.AtadosConAlambreTransportes.ToString())
                fabricanteaux = EFabricante.AtadosConAlambreTransportes;
            else
                fabricanteaux = EFabricante.PatitosTransportes;

            Avion avion = new Avion(velocidad, fabricanteaux, aeroliena);

            AvionXML avionXML = new AvionXML();

            avionXML.Guarda(avion);
        }

        private void BtnViajar_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarTrenes_Click(object sender, EventArgs e)
        {

        }

        private void ComenzarViaje(Transporte transporte)
        {
            MessageBox.Show(transporte.Transportar(transporte));
        }

        private void BtnMostrarAvion_Click(object sender, EventArgs e)
        {
            string aeroliena = txtAerolineaEmpresa.ToString();
            int velocidad = Convert.ToInt32(txtVelocidad.ToString());
            string fabricante = cmbFabricante.ToString();

            EFabricante fabricanteaux;
            if (fabricante == EFabricante.AtadosConAlambreTransportes.ToString())
                fabricanteaux = EFabricante.AtadosConAlambreTransportes;
            else
                fabricanteaux = EFabricante.PatitosTransportes;

            Avion avion = new Avion(velocidad, fabricanteaux, aeroliena);

            TrenDAO trenDAO = new TrenDAO();

            avion.EventoTransporte += trenDAO.Guarda;
            avion.EventoTransporte += ComenzarViaje;

            Thread hiloEvento = new Thread(avion.EjecutarDelegado);
            hiloEvento.Start();

            //AvionXML.Guarda(avion);
        }

        private void BtnAgregarTren_Click(object sender, EventArgs e)
        {

        }

        private void RSPyFinalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread th in hilos)
                th.Abort();
        }
    }
}
