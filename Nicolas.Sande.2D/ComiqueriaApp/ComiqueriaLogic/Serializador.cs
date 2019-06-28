using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic
{
    public static class Serializador<S> 
    {
        static Serializador()
        { }

        static void GuardarXML(string archivo, S datos)
        {
            XmlTextWriter writer;
            XmlSerializer ser;

            writer = new XmlTextWriter(archivo, Encoding.UTF32);
            ser = new XmlSerializer(typeof(S));

            try
            {
                ser.Serialize(writer, datos);
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            finally
            {
                writer.Close();
            }
        }

        static void Leer(string archivo, out S datos)
        {
            S a;
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + archivo);

                ser = new XmlSerializer(typeof(S));

                a = (S)ser.Deserialize(reader);

                datos = a;

                reader.Close();
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }
            catch (DirectoryNotFoundException e)
            {
                throw new ComiqueriaLogic.ComiqueriaException("Error: Directorio no encontrado", e);
            }

        }
    }
}
