using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Manual : Libro
    {
        public ETipo tipo;

        public static implicit operator double(Manual m)
        {
            return m.CantidadDePaginas;
        }

        public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo):base(titulo, nombre, apellido, precio)
        {
            this.tipo = tipo;
        }

        public static bool operator ==(Manual a, Manual b)
        {
            bool retorno = false;

            if (a.tipo == b.tipo && (Libro)a == (Libro)b)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Manual a, Manual b)
        {
            return !(a == b);
        }

        public string Mostrar()
        {
            return (string)this + "Tipo: " + this.tipo + "\n";
        }

    }
}
