using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
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

        public static explicit operator Peso(Dolar d)
        {
            Peso retorno = new Peso((d.GetCantidad()*38.33), Peso.GetCotizacion());
            return retorno;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro retorno = new Euro((d.GetCantidad()/1.16), Euro.GetCotizacion());
            return retorno;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar retorno = new Dolar(d, GetCotizacion());
            return retorno;
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            if (((Dolar)p).GetCantidad() == d.GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            if (p == d)
                return false;
            else
                return true;
        }

        public static bool operator ==(Dolar p, Euro e)
        {
            if (p.GetCantidad() == ((Dolar)e).GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Dolar p, Euro e)
        {
            if (p == e)
                return false;
            else
                return true;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            if (d1.GetCantidad() == d2.GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            if (d1 == d2)
                return false;
            else
                return true;
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad(), GetCotizacion());
            return retorno;
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad(), GetCotizacion());
            return retorno;
        }
    }
}
