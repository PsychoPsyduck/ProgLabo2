using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public static class ArchivoTexto
    {
        public static void Escribir(IArchivoTexto archivoTexto, bool append)
        {
            if(append)
            {
                string path = archivoTexto.Ruta;

                StreamWriter sw = new StreamWriter(path, true);
                try
                {
                    sw.WriteLine(archivoTexto.Texto);
                }
                catch
                {

                }
                finally
                {
                    sw.Close();
                }
            }
            else
            {
                string path = archivoTexto.Ruta;

                StreamWriter sw = new StreamWriter(path, true);
                try
                {
                    sw.WriteLine(archivoTexto.Texto);
                }
                catch
                {

                }
                finally
                {
                    sw.Close();
                }
            }
        }

        public static string Leer(string archivo)
        {
            StringBuilder retorno = new StringBuilder();
            StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo);
            try
            {

                //Hacer que lea todas las lineas.
                //while(endoffile?)
                do
                {
                    retorno.AppendLine(sr.ReadLine());
                }
                while (!sr.EndOfStream);
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("No se encontro archivo");
            }
            finally
            {
                sr.Close();
            }
            return retorno.ToString();
        }
    }
}
