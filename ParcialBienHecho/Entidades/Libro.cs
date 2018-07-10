using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private Autor _autor;
        private int _cantidadDePaginas;
        private static Random _generadorDePaginas;
        private float _precio;
        private string _titulo;

        public int CantidadDePaginas
        {
            get
            {
                if (this._cantidadDePaginas == 0)
                {
                    Libro._generadorDePaginas = new Random();
                    this._cantidadDePaginas = Libro._generadorDePaginas.Next(10, 580);
                }

                return this._cantidadDePaginas;
            }
        }

        public static explicit operator string(Libro l)
        {
            return "Autor: " + l._autor + " Cantidad de paginas: " + l.CantidadDePaginas + " Precio: " + l._precio + " Titulo: " + l._titulo + "\n"; 
        }

        static Libro()
        {
            Libro._generadorDePaginas = new Random();
        }

        public Libro(string titulo, string nombre, string apellido, float precio):this(titulo,new Autor(nombre, apellido),precio)
        {
            //this._titulo = titulo;
            //this._autor = new Autor(nombre, apellido);
            //this._precio = precio;
        }

        public Libro(string titulo, Autor autor, float precio)
        {
            this._autor = autor;
            this._titulo = titulo;
            this._precio = precio;
        }

        private static string Mostrar(Libro l)
        {
            return (string)l;
        }

        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;

            if (a._titulo == b._titulo && a._autor == b._autor)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
        }

    }
}
