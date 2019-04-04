using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Estante
    {
        private Producto[] producto;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            producto = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return producto;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Ubicacion estante: {0}\n", e.ubicacionEstante);
            retorno.AppendLine("--------------------------");
            foreach(var p in e.producto)
            {
                retorno.AppendLine(Producto.MostrarProducto(p));
            }

            return retorno.ToString();
        }

        public static bool operator ==(Estante e, Producto p)
        {
            foreach (var prod in e.producto)
            {
                if (prod == p)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            if (e == p)
                return false;
            else
                return true;
        }

        public static bool operator +(Estante e, Producto p)
        {
            for (int i = 0; i < e.producto.Length; i++)
            {
                if (ReferenceEquals(e.producto[i], null) && e != p)
                {
                    e.producto[i] = p;
                    return true;
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.producto.Length; i++)
            {
                if (e.producto[i] == p)
                {
                    e.producto[i] = null;
                    return e;
                }
            }
            return e;
        }
    }
}
