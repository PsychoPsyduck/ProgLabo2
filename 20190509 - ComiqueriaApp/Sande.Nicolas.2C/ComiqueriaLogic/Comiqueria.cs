using ComprobantesLogic;
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
        static Stack<Comprobante> comprobantes;
        /// <summary>
        /// 
        /// </summary>
        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }
        /// <summary>
        /// 
        /// </summary>
        static Comiqueria()
        {
            comprobantes = new Stack<Comprobante>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comprobante"></param>
        /// <returns></returns>
        public bool AgregarComprobante(Comprobante comprobante)
        {
            if (this != comprobante)
            {
                comprobantes.Push(comprobante);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        private bool AgregarComprobante(Venta venta)
        {
            Factura Factura = new Factura(venta, Factura.TipoFactura.B);
            if (AgregarComprobante(Factura))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="comprobante"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Comprobante comprobante)
        {
            return true;
            //foreach (Comprobante c in [comiqueria, comprobante])
            //{
               
            //}
        }/// <summary>
        /// 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="comprobante"></param>
        /// <returns></returns>
        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante)
        {
            if (comiqueria == comprobante)
                return false;
            else
                return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="ordenar"></param>
        /// <returns></returns>
        public List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                List<Comprobante> retorno = new List<Comprobante>();
                foreach (Comprobante c in comprobantes)
                {
                    if ((Guid)producto == (Guid)(Producto)c.Venta)
                    {
                        retorno.Add(c);
                    }
                }
                //if (ordenar)
                //    retorno.OrderBy(c => c);
                return retorno;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach (Producto p in productos)
            {
                retorno.Add((Guid)p, p.Descripcion);
            }
            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="producto"></param>
        public void Vender(Producto producto)
        {
            ventas.Add(new Venta(producto, 1));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto, int cantidad)
        {
            ventas.Add(new Venta(producto, cantidad));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            if (comiqueria == producto)
                return false;
            else
                return true;
        }/// <summary>
        /// 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            foreach (Producto p in comiqueria.productos)
            {
                if (p.Descripcion == producto.Descripcion)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
                comiqueria.productos.Add(producto);
            return comiqueria;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
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
