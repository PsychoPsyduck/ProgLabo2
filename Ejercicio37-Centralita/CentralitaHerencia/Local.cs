using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : this(new Llamada(duracion, destino, origen), costo)
        {
        }

        public override string Mostrar()
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

        public float CostoLlamada
        {
            get
            {
                return costo;
            }
        }
    }
}
