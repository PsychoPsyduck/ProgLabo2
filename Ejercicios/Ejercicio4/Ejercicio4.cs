using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int n = 1; 

            Console.WriteLine("Primeros 4 numero perfectos: ");

            do
            {
                int suma = 0;
                for (int i = 1; i < n; i++ )
                {
                    if(n % i == 0)
                        suma = suma + i;
                    if(suma == n)
                    {
                        Console.WriteLine("{0} ", n);
                        cant++;
                        break;
                    }
                }
                n++;
            } while (cant < 4);

            Console.ReadKey();
        }
    }
}
