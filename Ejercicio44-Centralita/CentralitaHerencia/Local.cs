using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : this(llamada.NroDestino, llamada.Duracion, llamada.NroDestino, costo)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
        }

        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0}", base.Mostrar());
            retorno.AppendFormat("    --LOCAL--\n");
            retorno.AppendFormat("Costo: {0}\n", CostoLlamada);
            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            float retorno = Duracion * CostoLlamada;
            return retorno;
        }

        public override float CostoLlamada
        {
            get
            {
                return costo;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
