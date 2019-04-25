using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("  --LLAMADA--\n");
            retorno.AppendFormat("Duracion: {0}\n", Duracion);
            retorno.AppendFormat("Nro Destino: {0}\n", NroDestino);
            retorno.AppendFormat("Nro Origen: {0}\n", NroOrigen);
            return retorno.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {

            return 0;
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public float NroDestino
        {
            get
            {
                return Convert.ToUInt32(nroDestino);
            }
        }

        public float NroOrigen
        {
            get
            {
                return Convert.ToUInt32(nroOrigen);
            }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
