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
            int suma = 0;
            int n = 2; 

            Console.WriteLine("Primeros 4 numero perfectos: ");

            do
            {
                for(int i = 0; i < n; i++ )
                {
                    suma += i;
                    if(suma == n)
                    {
                        Console.WriteLine("{0} ", n);
                        n++;
                        cant++;
                    }
                }
            } while (cant < 4);

            Console.ReadKey();
        }
    }
}
