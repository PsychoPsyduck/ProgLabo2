using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Ejercicio15
    {
        static void Main(string[] args)
        {
            char cont;
            do
            {
                Console.WriteLine("Ingrese el primer numero");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el operador");
                string oper = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo numero");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                Console.WriteLine("Si el 2do numero ingresado es 0, la operacion / devolvera el primer numero \n");
                Console.WriteLine("El resultado es: {0}", Calculadora.Calcular(num1, num2, oper));

                Console.WriteLine("Desea continuar? s/n");
                cont = Convert.ToChar(Console.ReadLine());
            } while (cont == 's' || cont == 'S');
        }
    }
}
