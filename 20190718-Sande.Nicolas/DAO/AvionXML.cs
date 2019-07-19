using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using EntidadesSPyFinal;
//using SPyFinal;

namespace Datos
{
    public class AvionXML : IData<Avion>
    {
        private static readonly string rutaArchivo;

        /// <summary>
        /// Asigna un valor al connectionString
        /// </summary>
        static AvionXML()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            rutaArchivo = path + "Avion.xml";
        }

        public void Guarda(Avion avion)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF32);
                ser = new XmlSerializer(typeof(Avion));

                ser.Serialize(writer, avion);
            }
            catch(Exception )
            {

            }
            finally
            {
                if(writer != null)
                    writer.Close();
            }
            

        }

        public Avion Leer()
        {
            Avion avion;
            XmlTextReader reader;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(rutaArchivo + "Avion.xml");

                ser = new XmlSerializer(typeof(Avion));

                avion = (Avion)ser.Deserialize(reader);
                
                reader.Close();

                return avion;
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException();
            }

        }
    }
}
