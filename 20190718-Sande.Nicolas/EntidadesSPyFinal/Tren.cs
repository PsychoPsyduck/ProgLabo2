using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public class Tren : Transporte
    {
        private string canVagones;
        protected EFabricante fabricante;
        private int velocidad;

        public event DelegadoTransporte EventoTransporte;

        public Tren(int velocidad, EFabricante fabricante, string cantidadVagones) : base(fabricante, velocidad)
        {
            this.canVagones = cantidadVagones;
            this.fabricante = fabricante;
            this.velocidad = velocidad;
        }

        public void EjecutarDelegado()
        {
            EventoTransporte.Invoke(this, null);
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Cant vagones: {0}\n{1}", this.canVagones, base.ToString());
            return retorno.ToString();
        }

        public override string Transportar(Transporte transporte)
        {
            if (EventoTransporte != null)
                throw new AvionException("No pudo volar");
            else
                return "Corre corre trencito";
        }

        public string CantidadVagones
        {
            get
            {
                return this.canVagones;
            }
            set
            {
                this.canVagones = value;
            }
        }
    }
}
