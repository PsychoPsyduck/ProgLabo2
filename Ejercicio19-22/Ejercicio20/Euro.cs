using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Peso(Euro d)
        {
            Peso retorno = new Peso((((Dolar)d).GetCantidad())/1.16, Peso.GetCotizacion());
            return retorno;
        }

        public static explicit operator Dolar(Euro d)
        {
            Dolar retorno = new Dolar((d.GetCantidad() / 1.16), Dolar.GetCotizacion());
            return retorno;
        }

        public static implicit operator Euro(double d)
        {
            Euro retorno = new Euro(d, GetCotizacion());
            return retorno;
        }

        public static bool operator ==(Euro d, Peso p)
        {
            if (((Dolar)p).GetCantidad() == ((Dolar)d).GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Euro d, Peso p)
        {
            if (p == d)
                return false;
            else
                return true;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            if (d.GetCantidad() == ((Dolar)e).GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            if (d == e)
                return false;
            else
                return true;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (e1.GetCantidad() == e2.GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            if (e1 == e2)
                return false;
            else
                return true;
        }

        public static Dolar operator +(Euro e, Peso p)
        {
            Dolar retorno = new Dolar(((Dolar)e).GetCantidad() + ((Dolar)p).GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Dolar operator -(Euro e, Peso p)
        {
            Dolar retorno = new Dolar(((Dolar)e).GetCantidad() - ((Dolar)p).GetCantidad(), GetCotizacion());
            return retorno;
        }

        public static Dolar operator +(Euro e, Dolar d)
        {
            Dolar retorno = new Dolar(((Dolar)e).GetCantidad() + d.GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Dolar operator -(Euro d, Dolar e)
        {
            Dolar retorno = new Dolar(((Dolar)e).GetCantidad() - d.GetCantidad(), GetCotizacion());
            return retorno;
        }
    }
}
