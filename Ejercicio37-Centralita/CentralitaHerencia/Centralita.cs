using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
        }

        public Centralita(string nombreEmpresa)
        {
            listaDeLlamadas = new List<Llamada>();
            razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("  --Centralita--\n");
            retorno.AppendFormat("Razon: {0}\n", razonSocial);
            retorno.AppendFormat("Gan_Total: {0}\n", CalcularGanancia(TipoLlamada.Todas));
            retorno.AppendFormat("Gan_Local: {0}\n", CalcularGanancia(TipoLlamada.Local));
            retorno.AppendFormat("Gan_Provincia: {0}\n", CalcularGanancia(TipoLlamada.Provincial));
            retorno.AppendFormat("Llamadas:\n");
            foreach (Llamada llamada in Llamadas)
            {
                if (llamada is Local)
                {
                    Local aux = (Local)llamada;
                    retorno.AppendLine(aux.Mostrar());
                }
                else if (llamada is Provincial)
                {
                    Provincial aux = (Provincial)llamada;
                    retorno.AppendLine(aux.Mostrar());
                }
            }
            return retorno.ToString();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada ll in Llamadas)
                    {
                        if (ll is Local)
                        {
                            Local aux = (Local)ll;
                            retorno += aux.CostoLlamada;
                        }
                    }
                    return retorno;
                case TipoLlamada.Provincial:
                    foreach (Llamada ll in Llamadas)
                    {
                        if (ll is Provincial)
                        {
                            Provincial aux = (Provincial)ll;
                            retorno += aux.CostoLlamada;
                        }
                    }
                    return retorno;
                default:
                    foreach (Llamada ll in Llamadas)
                    {
                        if (ll is Local)
                        {
                            Local aux = (Local)ll;
                            retorno += aux.CostoLlamada;
                        }
                        else
                        {
                            Provincial aux = (Provincial)ll;
                            retorno += aux.CostoLlamada;
                        }
                    }
                    return retorno;
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }
    }
}
