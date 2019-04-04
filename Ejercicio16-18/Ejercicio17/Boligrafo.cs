using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            if (GetTinta() <= (cantidadTintaMaxima - tinta) && tinta > 0)
            {
                this.tinta -= tinta;
            }
            else if((GetTinta() + tinta) > cantidadTintaMaxima && tinta > 0)
            {
                this.tinta = cantidadTintaMaxima;
            }
            else if(GetTinta() >= (0 + tinta) && tinta <= 0)
            {
                this.tinta += tinta;
            }
            else if(GetTinta() < tinta)
            {
                this.tinta = 0;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            StringBuilder retorno = new StringBuilder();
            if (GetTinta() > 0)
            {
                SetTinta((short)(-gasto));
                for (int i = 0; i < GetTinta(); i++)
                {
                    retorno.Append("*");
                }
                dibujo = retorno.ToString();
                return true;
            }
            else
            {
                dibujo = retorno.ToString();
                return false;
            }
        }
    }
}
