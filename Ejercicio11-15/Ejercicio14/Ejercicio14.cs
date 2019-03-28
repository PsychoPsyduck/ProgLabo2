using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            Console.WriteLine("Ingrese el cuadrado: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularCuadrado(num1));


            Console.WriteLine("Ingrese los 2 del triangulo: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el que resta del triangulo: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularTriangulo(num1, num2));

            Console.WriteLine("Ingrese el circulo: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularCirculo(num1));

            Console.ReadKey();
        }
    }
}
