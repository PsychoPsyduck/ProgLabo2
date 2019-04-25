using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil(4, 3, Colores.Azul, 6, 2);
            Moto moto = new Moto(2, 0, Colores.Rojo, 250);
            Camion camion = new Camion(6, 2, Colores.Rojo, 16, 2000);

            Console.WriteLine("auto: {0} {1} {2} {3} {4}", auto.cantidadPasajeros, auto.cantidadMarchas, auto.color, auto.cantidadRuedas, auto.cantidadPasajeros);
            Console.WriteLine("moto: {0} {1} {2} {3} {4}", camion.cantidadMarchas, camion.cantidadPuertas, camion.color, camion.pesoCarga, camion.cantidadRuedas);
            Console.WriteLine("camion: {0} {1} {2} {3}", moto.cantidadPuertas, moto.cantidadRuedas, moto.color, moto.cilindrada);

            Console.ReadKey();
        }
    }
}
