using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16_18
{
    public class Alumno
    {
        protected byte nota1;
        protected byte nota2;
        protected float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            if(nota1 >= 4 && nota2 >= 4)
            {
                Random rand = new Random();
                notaFinal = rand.Next(4, 10);
            }
            else
            {
                notaFinal = -1;
            }
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat("Alumno: {0}, {1}\n", apellido, nombre);
            retorno.AppendFormat("Legajo: {0}\n", legajo);
            retorno.AppendFormat("Nota1: {0} y nota2: {1}\n", nota1, nota2);

            CalcularFinal();
            if (notaFinal >= 4)
                retorno.AppendFormat("Nota final: {0}", notaFinal);
            else
                retorno.AppendFormat("Alumno desaprobado");

            return retorno.ToString();
        }
    }
}
