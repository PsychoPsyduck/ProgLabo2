using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double d)
        {
            return (d * 4);
        }

        public static double CalcularTriangulo(double a, double b)
        {
            return ((a * 2) + b);
        }

        public static double CalcularCirculo(double c)
        {
            return (3.14F * Math.Pow(2, c));
        }
    }
}
