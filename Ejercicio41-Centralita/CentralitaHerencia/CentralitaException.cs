using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class CentralitaException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CentralitaException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            nombreClase = clase;
            nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {

        }

        public string NombreClase
        {
            get
            {
                return nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return nombreMetodo;
            }
        }
    }
}
