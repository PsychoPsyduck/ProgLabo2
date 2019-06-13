using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio64
{
    class Caja
    {
        private List<string> filaClientes;

        public Caja()
        {
            filaClientes = new List<string>();
        }

        public void AtenderClientes()
        {
            foreach (var item in FilaClientes)
            {
                Console.WriteLine(item);
            }
        }

        public List<string> FilaClientes
        {
            get
            {
                return filaClientes;
            }
        }
    }
}
