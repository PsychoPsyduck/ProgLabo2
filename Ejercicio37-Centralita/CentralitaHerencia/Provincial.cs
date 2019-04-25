using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial
    {
        protected Franja franjaHoraria;

        public Provincial(Franja miFranja, Llamada llamada)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
        {

        }

        public string Mostrar()
        {
            return "";
        }

        private float CalcularCosto()
        {
            return 0;
        }

        public float CostoLlamada
        {
            get;
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
