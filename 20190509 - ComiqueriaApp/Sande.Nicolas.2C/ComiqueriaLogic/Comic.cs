using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {/// <summary>
    /// 
    /// </summary>
        public enum TipoComic
        {
            Occidental,
            Oriental
        }

        private string autor;
        private TipoComic tipoComic;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="autor"></param>
        /// <param name="tipoComic"></param>
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(base.ToString());
            retorno.AppendLine("    --COMIC--");
            retorno.AppendFormat("Autor: {0}\n", autor);
            retorno.AppendFormat("Tipo Comic: {0}", tipoComic);

            return retorno.ToString();
        }
    }
}
