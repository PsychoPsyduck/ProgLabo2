using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador()
        {
            cantidadSumas = 0;
        }
        
        public long Sumar(long a, long b)
        {
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            return (a + b);
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return ((int)s1 + (int)s2);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }
    }
}
