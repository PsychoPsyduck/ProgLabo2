using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja, new Llamada(duracion, destino, origen))
        {
            franjaHoraria = miFranja;
        }

        public override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("{0}", base.Mostrar());
            retorno.AppendFormat("    --Provincial--\n");
            retorno.AppendFormat("Costo: {0}\n", CostoLlamada);
            retorno.AppendFormat("Franja: {0}\n", franjaHoraria);
            return retorno.ToString();
        }

        private float CalcularCosto()
        {
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    return (float)(Duracion * 0.99);
                case Franja.Franja_2:
                    return (float)(Duracion * 1.25);
                default:
                    return (float)(Duracion * 0.66);
            }
        }

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
