using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        protected override string Mostrar()
        {
            return base.Mostrar() + " - Cilindrada: " + this._cilindrada;
        }

        public Moto(float cilindrada, string patente, byte cantRuedas, EMarcas marca):base(patente, cantRuedas, marca)
        {
            this._cilindrada = cilindrada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Moto && (this == (Moto)obj))
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Acelerar()
        {
            return "La moto esta acelerado";
        }
    }
}
