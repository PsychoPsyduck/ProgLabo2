using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class FormatearPrecioExtension
    {
        public static string FormatearPrecio(this double str)
        {
            String retorno = String.Format("${0:0.00}", str.ToString());

            return retorno;
        }
    }
}
