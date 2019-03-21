using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            int num;
            int cant = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int total = 0;
            int prom;

            for(int i = 0; i < 5;i++)
            {
                Console.WriteLine("Ingrese el {0}º numero", (i+1));
                num = Convert.ToInt32(Console.ReadLine());

                if (cant == 0)
                {
                    min = num;
                    max = num;
                    total += num;
                }
                else if(num <= min)
                {
                    min = num;
                    total += num;
                }
                else
                {
                    max = num;
                    total += num;
                }
                cant++;
            }
            prom = total / cant;
            Console.WriteLine("El menor es: {0} el mayor: {1} el promedio: {2}", min, max, prom);
            Console.ReadKey();
        }
    }
}
