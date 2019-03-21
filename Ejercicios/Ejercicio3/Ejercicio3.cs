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
            int flag = 0;
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int e = 0;

            for (int i = 0; i < num; i++)
            {
                while (flag == 0)
                {
                    int numAux = num % i;
                    if(numAux == 0)
                        e++;
                    if (e == 3)
                        flag = 1;
                }

            }

            Console.ReadKey();
        }
    }
}
