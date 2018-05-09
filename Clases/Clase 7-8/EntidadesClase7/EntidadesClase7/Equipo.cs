using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase7
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            this.cantidadDeJugadores = 5;
            
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;

            bool validacion = false;

            foreach (Jugador jug in e.jugadores)
            {
                validacion = jug == j;

                if (validacion)
                {
                    break;
                }
            }

            if (validacion == false && e.cantidadDeJugadores > e.jugadores.Count)
            {
                e.jugadores.Add(j);
                retorno = true;
            }

            return retorno;
        }

        public List<Jugador> GetJugadores()
        {
            return this.jugadores;
        }


        public static bool operator -(Equipo e, Jugador j)
        {
            bool retorno = false;

            bool validacion = false;

            foreach (Jugador jug in e.jugadores)
            {
                validacion = jug == j;

                if (validacion)
                {
                    e.jugadores.Remove(jug);
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

    }
}
