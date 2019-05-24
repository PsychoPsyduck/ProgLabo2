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
        private int cantidad;
        /// <summary>
        /// 
        /// </summary>
        static Venta()
        {
            porcentajelva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            Vender(cantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            fecha = DateTime.Now;
            precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="precioUnidad"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double resultado = precioUnidad * cantidad;
            double porcentaje = (porcentajelva * resultado) / 100;
            return (resultado + porcentaje);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Desc. breve: {0} - {1} - {2}", fecha, producto.Descripcion, precioFinal);
            return retorno.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        public static explicit operator Producto(Venta v)
        {
            return v.producto;
        }
    }
}
