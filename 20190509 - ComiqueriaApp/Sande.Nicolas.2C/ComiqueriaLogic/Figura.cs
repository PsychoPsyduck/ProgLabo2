using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        private double altura;

        public Figura(int stock, double precio, double altura) : this("Figura " + altura + "cm",stock, precio, altura)
        {
            this.altura = altura;
        }

        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion,stock,precio)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(base.ToString());
            retorno.AppendLine("    --Figura--");
            retorno.AppendFormat("Altura: {0}", altura);

            return retorno.ToString();
        }
    }
}
