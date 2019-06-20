using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto<Queue> : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue<Patente> datos)
        {
            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + archivo);

            foreach (var d in datos)
            {
                sw.WriteLine(d.ToString());
            }
            sw.Close();
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            try
            {
                StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + archivo);
                //Hacer que lea todas las lineas.
                Patente p = new Patente();
                p.CodigoPatente = sr.ReadLine();
                datos.Enqueue(p);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("No se encontro archivo");
            }
        }
    }
}
