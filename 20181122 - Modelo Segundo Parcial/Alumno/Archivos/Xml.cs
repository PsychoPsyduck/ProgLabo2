using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            writer = new XmlTextWriter(archivo, Encoding.UTF32);
            ser = new XmlSerializer(typeof(T));

            ser.Serialize(writer, datos);

            writer.Close();
        }

        public void Leer(string archivo, out T datos)
        {
            T a;
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + archivo);

                ser = new XmlSerializer(typeof(T));

                a = (T)ser.Deserialize(reader);

                datos = a;

                reader.Close();
            }
            catch(FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            
        }
    }
}
