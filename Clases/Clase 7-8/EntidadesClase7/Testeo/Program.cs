using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesClase7;

namespace Testeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo boca = new Equipo(9,"Boca");

            Jugador jugador1 = new Jugador("Juan", 123456, 10, 2);

            Jugador jugador2 = new Jugador("Jorge", 456789, 5, 3);

            Jugador jugador3 = new Jugador("Manuel", 101112, 4, 1);

            List<Jugador> lista = boca.GetJugadores();


        }
    }
}
