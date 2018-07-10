using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        public double PrecioDeManuales 
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }

        }

        public double PrecioDeNovelas 
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal 
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Ambos);
            }
        }


        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca biblioteca = new Biblioteca(capacidad);

            return biblioteca;
        }

        public static string Mostrar(Biblioteca e)
        {
            string retorno = "";

            foreach(Libro l in e._libros)
            {
                if (l is Manual)
                {
                    retorno += ((Manual)l).Mostrar();
                }
                if (l is Novela)
                {
                    retorno += ((Novela)l).Mostrar();
                }
            }

            return retorno;
        }

        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double acum = 0;

            switch (tipoLibro)
            {
                case ELibro.Manual:
                    foreach (Libro l in this._libros)
                    {
                        if (l is Manual)
                        {
                            acum += ((Manual)l);
                        }
                    }
                    break;

                case ELibro.Novela:
                    foreach (Libro l in this._libros)
                    {
                        if (l is Novela)
                        {
                            acum += ((Novela)l);
                        }
                    }
                    break;

                case ELibro.Ambos:
                    foreach (Libro l in this._libros)
                    {
                        if (l is Manual && l is Novela)
                        {
                            acum += ((Novela)l);
                        }
                    }
                    break;
            }

            return acum;
        }

        public static bool operator ==(Biblioteca e, Libro l)
        {
            bool retorno = false;

            foreach (Libro libro in e._libros)
            {
                if (l == libro)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Biblioteca e, Libro l)
        {
            return !(e == l);
        }

        public static Biblioteca operator +(Biblioteca e, Libro l)
        {
            int cantidad = 0;

            foreach (Libro libro in e._libros)
            {
                cantidad++;
            }

            if (e._capacidad > cantidad)
            {
                e._libros.Add(l);
            }

            return e;
        }
    }
}
