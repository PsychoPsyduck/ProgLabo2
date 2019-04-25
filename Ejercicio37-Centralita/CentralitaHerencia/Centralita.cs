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

        }

        public string Mostrar()
        {
            return "";
        }

        public void OrdenarLlamada()
        {

        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            return 0;
        }

        public float GananciaPorLocal
        {
            get;
        }

        public float GananciaPorProvincial
        {
            get;
        }

        public float GananciaTotal
        {
            get;
        }

        public List<Llamada> Llamadas
        {
            get;
        }
    }
}
