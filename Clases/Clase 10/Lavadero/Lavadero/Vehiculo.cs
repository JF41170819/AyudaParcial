using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public abstract class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public string Patente 
        {
            get {return this._patente;} 
        }
        public EMarcas Marca 
        {
            get {return this._marca;} 
        }

        protected virtual string Mostrar()
        {
            return this._patente + " - " + this._cantRuedas + " - " + this._marca;
        }

        public Vehiculo(string patente, byte cantRuedas, EMarcas marca)
        {
            this._patente = patente;
            this._cantRuedas = cantRuedas;
            this._marca = marca;
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (v1.Marca == v2.Marca && v1.Patente == v2.Patente)//Utilizo el get
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public abstract string Acelerar();

    }
}
