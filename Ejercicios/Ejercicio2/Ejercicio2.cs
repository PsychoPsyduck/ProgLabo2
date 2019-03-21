using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());
            
            while(num <= 0)
            {
                Console.WriteLine("Error, reintentar");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("El cuadrado es {0} y el cubo {1}", Math.Pow(num, 2), Math.Pow(num, 3));
            Console.ReadKey();
        }
    }
}
