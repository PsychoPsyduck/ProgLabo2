using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double d)
        {
            string n = "";
            int dAux = Convert.ToInt32(d);
            if (dAux == 1 || dAux == 0)
            {
                return d.ToString();
            }
            while(dAux != 0)
            {
                n = string.Format("{0}{1}",(dAux % 2).ToString(), n);
                dAux = dAux / 2;
            }

            return n;
        }
        
        public static double BinarioDecimal(string b)
        {
            double retorno = 0;
            char[] cadena = b.ToCharArray();

            if (b == "1" || b == "0")
            {
                return Convert.ToDouble(b);
            }

            for (int i = 1; i <= b.Length; i++)
            {
                if (cadena[(cadena.Length - i)] == '1' )
                {
                    retorno += (1 * Math.Pow(2, (i-1)));
                }
            }

            return retorno;
        }

    }
}
