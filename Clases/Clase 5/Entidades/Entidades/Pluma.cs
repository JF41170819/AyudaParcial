using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Entidades
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this.marca = marca;
            this.tinta = tinta;
            this.cantidad = cantidad;
        }

        public Pluma():this("Sin marca", null , 0)
        {

        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca):this()
        {
            this.marca = marca;
        }

        private string Mostrar()
        {
            return this.marca + " - " + Tinta.Mostrar(this.tinta) + " - " + this.cantidad;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            bool retorno = false;

            if(pluma.tinta == tinta)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma.cantidad < 100)
            {
                pluma.cantidad++;
            }

            return pluma;
        }

        //Podemos simular el operador +=, utilizando las sobrecargas de + e =.

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta && pluma.cantidad > 0)
            {
                pluma.cantidad--;
            }

            return pluma;
        } 

    }
}
