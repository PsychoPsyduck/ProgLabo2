using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            ruedas = 2;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora) : this(patente, cilindrada)
        {
            Moto.valorHora = valorHora;
        }

        public override string ConsultarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("    --Moto - Con. Datos--\n");
            retorno.AppendFormat("Patente: {0}\n", ToString());
            retorno.AppendFormat("Cilindrada: {0}\n", cilindrada);
            retorno.AppendFormat("Ruedas: {0}\n", ruedas);
            retorno.AppendFormat("Valor hora: {0}\n", valorHora);
            return retorno.ToString();
        }

        public override bool Equals(object obj)
        {
            //if (obj)
            //    return true;
            //else
                return false;
        }

        public override string ImprimirTicket()
        {
            DateTime now = DateTime.Now;
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0}\n", base.ImprimirTicket());
            retorno.AppendFormat("  --Moto - IMP. TICKET--\n");
            retorno.AppendFormat("Patente: {0}\n", ToString());
            retorno.AppendFormat("Ingreso: {0} x {1}\n", now.Subtract(ingreso), valorHora);
            return retorno.ToString();
        }
    }
}
