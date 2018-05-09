using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public class Camion : Vehiculo
    {
        protected float _tara;

        protected override string Mostrar()
        {
            return base.Mostrar() + " - Tara: " + this._tara;
        }

        public Camion(float tara, string patente, byte cantRuedas, EMarcas marca):base(patente, cantRuedas, marca)
        {
            this._tara = tara;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Camion && (this == (Camion)obj))
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Acelerar()
        {
            return "El camion esta acelerado";
        }
    }
}
