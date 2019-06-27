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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo;

            StreamWriter sw = new StreamWriter(path, true);
            //try
            foreach (var d in datos)
            {
                sw.WriteLine(d.ToString());
            }
            //catch
            //Finally
            sw.Close();
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo);
            try
            {
                
                //Hacer que lea todas las lineas.
                //while(endoffile?)
                Patente p = new Patente();
                p.CodigoPatente = sr.ReadLine();
                datos.Enqueue(p);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("No se encontro archivo");
            }
            finally
            {
                sr.Close();
            }
        }
    }
}
