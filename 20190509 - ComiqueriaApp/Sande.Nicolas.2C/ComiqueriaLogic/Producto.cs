using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        protected Producto(string descripcion, int stock, double precio)
        {
            codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("    --PRODUCTO--");
            retorno.AppendFormat("Descripcion: {0}\n", Descripcion);
            retorno.AppendFormat("Codigo: {0}\n", codigo);
            retorno.AppendFormat("Precio: {0}\n", Precio);
            retorno.AppendFormat("Stock: {0}", Stock);

            return retorno.ToString();
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if(value >= 0)
                {
                    stock = value;
                }
            }
        }
    }
}
