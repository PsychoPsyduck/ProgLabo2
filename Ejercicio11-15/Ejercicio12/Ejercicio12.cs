using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Ejercicio12
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese el 1º numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el 2º numero: ");
            num += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma es de: {0}", num);
            Console.WriteLine("Desea seguir sumando? s/n");
            string n = Console.ReadLine();

            while (ValidarRespuesta.ValidarS_N(Convert.ToChar(n)))
            {
                Console.WriteLine("Ingrese el siguiente numero: ");
                num += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La suma es de: {0}", num);
                Console.WriteLine("Desea seguir sumando? s/n");
                n = Console.ReadLine();
            }

            Console.WriteLine("La suma final fue de: {0}", num);
            Console.ReadKey();
        }
    }
}
