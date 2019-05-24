using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprobantesLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmisor;
        private Venta venta;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="venta"></param>
        public Comprobante(Venta venta)
        {
            fechaEmisor = venta.Fecha;
            this.venta = venta;
        }
        /// <summary>
        /// 
        /// </summary>
        internal Venta Venta
        {
            get
            {
                return venta;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract string GenerarComprobante();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Comprobante && ((Comprobante)obj).fechaEmisor == this.fechaEmisor)
                return true;
            else
                return false;
        }
    }
}
