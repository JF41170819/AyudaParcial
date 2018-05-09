using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        protected override string Mostrar()
        {
            return base.Mostrar() + " - Cantidad de asientos: " + this._cantidadAsientos;
        }

        public Auto(int cantidadAsientos, string patente, byte cantRuedas, EMarcas marca):base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cantidadAsientos;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Auto && (this == (Auto)obj))
            {
                retorno = true;
            }

            return retorno;
        }

        public override string Acelerar()
        {
            return "El auto esta acelerado";
        }
    }
}
