using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador suma = new Sumador(2);

            Console.WriteLine(suma.Sumar(2, 1));
            Console.WriteLine(suma.Sumar("hola ", "mundo"));

            Console.ReadKey();

            Sumador suma2 = new Sumador(77);


            Console.WriteLine(suma + suma2);
            Console.WriteLine(suma | suma2);

            Console.ReadKey();
        }
    }
}
