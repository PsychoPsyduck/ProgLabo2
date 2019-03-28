using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            int num;
            int min = int.MaxValue;
            int max = int.MinValue;
            int cont = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el {0}º numero: ", (i+1));
                num = Convert.ToInt32(Console.ReadLine());

                while(!Validacion.Validar(num, -100, 100))
                {
                    Console.WriteLine("Error, reingrese el {0}º numero: ", (i+1));
                    num = Convert.ToInt32(Console.ReadLine());
                }

                if(num < min)
                {
                    min = num;
                }
                else if(num > max)
                {
                    max = num;
                }
                cont += num;
            }

            Console.WriteLine("Valor min: {0} Valor max: {1} Promedio: {2}", min, max, (cont/10));

            Console.ReadKey();
        }
    }
}
