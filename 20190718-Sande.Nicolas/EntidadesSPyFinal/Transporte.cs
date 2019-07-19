using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public abstract class Transporte
    {
        private int velocidad;
        private EFabricante fabricante;
        
        protected Transporte(EFabricante fabricante, int velocidad)
        {
            this.velocidad = velocidad;
            this.fabricante = fabricante;
        }

        public abstract string Transportar(Transporte transporte);

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendFormat(" \n.{0}kph  \n. {1}", this.velocidad, this.fabricante);
            return retorno.ToString();
        }

        public EFabricante Fabricante
        {
            get
            {
                return this.fabricante;
            }
            set
            {
                this.fabricante = value;
            }
        }

        public int Velocidad
        {
            get
            {
                return this.velocidad;
            }
            set
            {
                this.velocidad = value;
            }
        }
    }
}
