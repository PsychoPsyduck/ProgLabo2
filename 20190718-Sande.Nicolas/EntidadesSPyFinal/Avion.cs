using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public class Avion : Transporte
    {
        private string aerolinea;
        private int velocidad;
        protected EFabricante fabricante;

        public event DelegadoTransporte EventoTransporte;

        public Avion(int velocidad, EFabricante fabricante, string aerolinea) : base(fabricante, velocidad)
        {
            this.velocidad = velocidad;
            this.fabricante = fabricante;
            this.aerolinea = aerolinea;
        }

        public override string Transportar(Transporte transporte)
        {
            if (EventoTransporte != null)
                throw new AvionException("No pudo volar");
            else
                return "Vuela vuela avionsito";
        }

        public void EjecutarDelegado()
        {
            EventoTransporte.Invoke(this, null);
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Aerolinea: {0}\n{1}", this.aerolinea, base.ToString());
            return retorno.ToString();
        }

        public static bool operator ==(Avion avion1, Avion avion2)
        {
            if (avion1.fabricante == avion2.fabricante && avion1.aerolinea == avion2.aerolinea)
                return true;
            else
                return false;
        }

        public static bool operator !=(Avion avion1, Avion avion2)
        {
            if (avion1 == avion2)
                return false;
            else
                return true;
        }

        public string Aerolinea
        {
            get
            {
                return this.aerolinea;
            }
            set
            {
                this.aerolinea = value;
            }
        }
    }
}
