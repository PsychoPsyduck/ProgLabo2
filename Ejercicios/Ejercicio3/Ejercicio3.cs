using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int cont = 0;

            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        cont++;
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
