using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return marca;
        }

        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Codigo de barras: {0}\n", p.codigoDeBarra);
            retorno.AppendFormat("Marca: {0}\n", p.GetMarca());
            retorno.AppendFormat("Precio: {0}\n", p.GetPrecio());

            return retorno.ToString();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (ReferenceEquals(p1, p2) && p1.marca == p2.marca)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1 == p2)
                return false;
            else
                return true;
        }

        public static bool operator ==(Producto p, string marca)
        {
            if (p.GetMarca() == marca)
                return true;
            else
                return false;
        }
        public static bool operator !=(Producto p, string marca)
        {
            if (p == marca)
                return false;
            else
                return true;
        }
    }
}
