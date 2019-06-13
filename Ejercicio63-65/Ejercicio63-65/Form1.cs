using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63_65
{
    public partial class Form1 : Form
    {
        Thread hilo;

        public Form1()
        {
            InitializeComponent();
            this.hilo = new Thread(this.AsignarHora);
            hilo.Start();

        }

        public void AsignarHora()
        {
            do
            {
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.Now.ToString();
                    }
                    );
                }
                else
                {
                    this.lblHora.Text = DateTime.Now.ToString();
                }

                Thread.Sleep(500);
            } while (true);
        }
    }
}
