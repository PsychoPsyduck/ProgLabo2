using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Peso
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Peso()
        {
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, float cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Peso p)
        {
            Dolar retorno = new Dolar((p.GetCantidad() / 38.33), Dolar.GetCotizacion());
            return retorno;
        }

        public static explicit operator Euro(Peso p)
        {
            Euro retorno = new Euro((((Dolar)p).GetCantidad()/1.16), Euro.GetCotizacion());
            return retorno;
        }

        public static implicit operator Peso(double d)
        {
            Peso retorno = new Peso(d, GetCotizacion());
            return retorno;
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            if (((Dolar)p).GetCantidad() == d.GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            if (p == d)
                return false;
            else
                return true;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            if (((Dolar)p).GetCantidad() == ((Dolar)e).GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            if (p == e)
                return false;
            else
                return true;
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            if (p1.GetCantidad() == p2.GetCantidad())
                return true;
            else
                return false;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            if (p1 == p2)
                return false;
            else
                return true;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            Peso retorno = new Peso(p.GetCantidad() + ((Peso)d).GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            Peso retorno = new Peso(p.GetCantidad() - ((Peso)d).GetCantidad(), GetCotizacion());
            return retorno;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            Peso retorno = new Peso(p.GetCantidad() + ((Peso)e).GetCantidad(), GetCotizacion());
            return retorno;
        }
        public static Peso operator -(Peso p, Euro e)
        {
            Peso retorno = new Peso(p.GetCantidad() - ((Peso)e).GetCantidad(), GetCotizacion());
            return retorno;
        }
    }
}
