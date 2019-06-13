using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            clientes = new List<string>();
        }

        public void AsignarCaja()
        {

        }

        public Caja Caja1
        {
            get
            {
                return caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return clientes;
            }
        }
    }
}
