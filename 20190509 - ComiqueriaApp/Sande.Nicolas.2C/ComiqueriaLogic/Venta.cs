using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajelva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            porcentajelva = 21;
        }

        public Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            fecha = DateTime.Now;
            precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double resultado = precioUnidad * cantidad;
            double porcentaje = (porcentajelva * resultado) / 100;
            return (resultado + porcentaje);
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Desc. breve: {0} - {1} - {2}", fecha, producto.Descripcion, precioFinal);
            return retorno.ToString();
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }
    }
}
