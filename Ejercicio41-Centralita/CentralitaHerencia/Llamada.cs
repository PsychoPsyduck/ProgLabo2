using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
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

        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("  --LLAMADA--\n");
            retorno.AppendFormat("Duracion: {0}\n", Duracion);
            retorno.AppendFormat("Nro Destino: {0}\n", NroDestino);
            retorno.AppendFormat("Nro Origen: {0}\n", NroOrigen);
            return retorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = -1;
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = 0;
            }
            return retorno;
        }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public abstract float CostoLlamada
        {
            get;
        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Equals(llamada2))
                return true;
            else
                return false;
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1 == llamada2)
                return false;
            else
                return true;    
        }
    }

    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
}
