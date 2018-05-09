using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase7
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            float promedio = this.totalGoles / this.partidosJugados;
            return promedio;
        }

        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos):this(nombre,dni)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = GetPromedioGoles();
        }

        public Jugador(string nombre, long dni):this()
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        private Jugador()
        {
            this.dni = 1;
            this.nombre = "Sin nombre";
            this.partidosJugados = 0;
            this.totalGoles = 0;
            this.promedioGoles = 0;
        }

        public string MostrarDatos()
        {
            return this.dni + " - " + this.nombre + " - " + this.totalGoles + " - " + this.partidosJugados;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool retorno = false;

            if (j1.dni == j2.dni)
            {
                retorno = true;
            }


            return retorno;

        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public long Dni 
        {
            get { return this.dni; } 
            set { this.dni = value; } 
        }
        public string Nombre 
        {
            get { return this.nombre; }
            set { this.nombre = value; } 
        }
        public int PartidosJugados 
        {
            get { return this.partidosJugados; }
            set { this.partidosJugados = value; } 
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
            set { this.totalGoles = value; } 
        }

    }
}
