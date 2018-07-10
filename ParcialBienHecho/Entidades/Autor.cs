using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autor
    {
        private string _nombre;
        private string _apellido;

        public Autor(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public static implicit operator string(Autor a)
        {
            return "Nombre: " + a._nombre + " Apellido: " + a._apellido + "\n";
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;

            if (a._nombre == b._nombre && a._apellido == b._apellido)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }

    }
}
