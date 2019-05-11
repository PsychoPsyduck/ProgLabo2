using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach (Producto p in productos)
            {
                retorno.Add((Guid)p, p.Descripcion);
            }
            return retorno;
        }

        public string ListarVentas()
        {
            StringBuilder retorno = new StringBuilder();

            List<Venta> listaRetorno = ventas.OrderByDescending(v => v.Fecha).ToList();

            foreach (Venta v in listaRetorno)
            {
                retorno.AppendLine(v.ObtenerDescripcionBreve());
            }
            return retorno.ToString();
        }

        public void Vender(Producto producto)
        {
            ventas.Add(new Venta(producto, 1));
        }

        public void Vender(Producto producto, int cantidad)
        {
            ventas.Add(new Venta(producto, cantidad));
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria == producto)
                return false;
            else
                return true;
        }
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                    return true;
            }
            return false;
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
                comiqueria.productos.Add(producto);
            return comiqueria;
        }

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto p in productos)
                {
                    if ((Guid)p == codigo)
                        return p;
                }
                return null;
            }
        }
    }
}
