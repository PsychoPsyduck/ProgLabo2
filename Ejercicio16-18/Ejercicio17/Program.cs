using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo Azul = new Boligrafo(10, ConsoleColor.Blue);
            Boligrafo Rojo = new Boligrafo(5, ConsoleColor.Red);
            string AzulD;
            string RojoD;

            Azul.Pintar(5, out AzulD);
            Rojo.Pintar(6, out RojoD);

            Console.WriteLine(AzulD);
            Console.WriteLine(RojoD);

            Console.ReadKey();
        }
    }
}
