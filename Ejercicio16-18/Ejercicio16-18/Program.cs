using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno gatito = new Alumno();
            gatito.nombre = "Gatito";
            gatito.apellido = "Bruno";
            gatito.legajo = 666;
            gatito.Estudiar(4, 5);
            Console.WriteLine(gatito.Mostrar());

            Console.ReadKey();

            Alumno tuca = new Alumno();
            tuca.nombre = "Chinchilla";
            tuca.apellido = "Lucy";
            tuca.legajo = 777;
            tuca.Estudiar(9, 10);
            Console.WriteLine(tuca.Mostrar());

            Console.ReadKey();

            Alumno lucy = new Alumno();
            lucy.nombre = "Gatita";
            lucy.apellido = "Tuca";
            lucy.legajo = 000;
            lucy.Estudiar(7, 6);
            Console.WriteLine(lucy.Mostrar());

            Console.ReadKey();
        }
    }
}
