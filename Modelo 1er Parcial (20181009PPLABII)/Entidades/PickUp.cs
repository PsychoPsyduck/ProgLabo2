using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class PickUp
    {
        private string modelo;
        private int valorHora;

        private PickUp()
        {

        }

        public PickUp(string patente, string modelo)
        {

        }

        public PickUp(string patente, string modelo, int valorHora)
        {

        }

        public string ConsultarDatos()
        {
            return "";
        }

        public bool Equals(object obj)
        {
            return false;
        }

        public string ImprimirTicket()
        {
            return "";
        }
    }
}
