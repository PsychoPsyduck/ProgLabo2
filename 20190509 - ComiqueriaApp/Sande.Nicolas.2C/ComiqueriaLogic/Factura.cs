using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
    class Factura : Comprobante
    {/// <summary>
    /// 
    /// </summary>
        public enum TipoFactura
        {
            A,
            B,
            C,
            E
        }
        /// <summary>
        /// 
        /// </summary>
        private DateTime fechaVencimiento;
        private TipoFactura tipoFactura;

        public Factura(Venta venta, int diasParaVencimiento, TipoFactura tipoFactura) : this(venta, tipoFactura)
        {
            this.tipoFactura = tipoFactura;
            fechaVencimiento = DateTime.Now; // +diasParaVencimiento;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="tipoFactura"></param>
        public Factura(Venta venta, TipoFactura tipoFactura) : base(venta)
        {
            this.tipoFactura = tipoFactura;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string GenerarComprobante()
        {
            double subtotal = (((Producto)Venta).Precio) * Venta.Cantidad;
            double total = Venta.CalcularPrecioFinal((((Producto)Venta).Precio), Venta.Cantidad);

            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("FACTURA: {0}\n\n", tipoFactura);
            retorno.AppendFormat("Fecha Emision: {0}\n", fechaEmisor);
            retorno.AppendFormat("Fecha Vencimiento: {0}\n\n", fechaVencimiento);
            retorno.AppendFormat("Producto: {0}\n", Venta.ObtenerDescripcionBreve());
            retorno.AppendFormat("Cantidad: {0}\n", Venta.Cantidad);
            retorno.AppendFormat("Precio Unitario: ${0}\n\n", ((Producto)Venta).Precio);//ver
            retorno.AppendFormat("Subtotal: ${0}\n", (((Producto)Venta).Precio) * Venta.Cantidad);
            retorno.AppendFormat("Importe IVA: ${0}\n", total - subtotal);
            retorno.AppendFormat("Importe Total: ${0}\n", Venta.CalcularPrecioFinal((((Producto)Venta).Precio), Venta.Cantidad));

            return retorno.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Factura && base.Equals(obj) && ((Factura)obj).tipoFactura == this.tipoFactura)
                return true;
            else
                return false;
        }
    }
}
