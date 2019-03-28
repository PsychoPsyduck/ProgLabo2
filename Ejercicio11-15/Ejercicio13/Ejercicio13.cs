using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            double num;
            string bin;
            Console.WriteLine("Ingrese un binario: ");
            bin = Console.ReadLine();

            num = Conversor.BinarioDecimal(bin);

            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
