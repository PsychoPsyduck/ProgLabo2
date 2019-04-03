using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double Calcular(double a, double b, string signo)
        {
            switch(signo)
            {
                case "/":
                    if (Validar(b))
                        return (a / b);
                    else
                        return a;
                case "*":
                    return (a*b);
                case "-":
                    return (a - b);
                default:
                    return (a + b);
            }
        }

        private static bool Validar(double b)
        {
            if (b == 0)
                return false;
            else
                return true;    
        }
    }
}
