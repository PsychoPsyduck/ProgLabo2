using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public Vehiculo(string patente)
        {
            ingreso = DateTime.Now.AddHours(-3);
            if (patente.Length == 6)
                this.patente = patente;
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("  --VEHICULO - IMP. TICKET--\n");
            retorno.AppendFormat("Patente: {0}\n", ToString());
            retorno.AppendFormat("Ingreso: {0}\n", ingreso);
            return retorno.ToString();
        }

        public override string ToString()
        {
            return String.Format(patente);
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            if (v1 == v2)
                return false;
            else
                return true;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if (v1.patente == v2.patente)
                return true;
            else
                return false;
        }
    }
}
