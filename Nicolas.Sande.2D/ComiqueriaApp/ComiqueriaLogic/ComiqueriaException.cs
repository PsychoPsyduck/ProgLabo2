using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException) 
        {
            //ArchivoTexto.Escribir();
        }

        public string Ruta
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "log.txt";
            }
        }

        public string Texto
        {
            get
            {
                string retorno = DateTime.Now.ToString() + this.Message + this.InnerException;
                return retorno;
            }
        }
    }
}
