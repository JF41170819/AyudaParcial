using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase9Herencia;

namespace ConsolaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavadero = new Lavadero(500, 900, 100);

            Camion camion = new Camion(100, "ABC123", 4, EMarcas.Iveco);
            Auto auto = new Auto(4, "DEF456", 4, EMarcas.Ford);
            Auto auto2 = new Auto(4, "DEF456", 4, EMarcas.Ford);
            Moto moto = new Moto(1, "GHI789", 2, EMarcas.Honda);

            lavadero += camion;
            lavadero += auto;
            lavadero += moto;

            //No estatico (de instancia)
            lavadero.GetVehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);

            Console.WriteLine("Ordenado por marca(Metodo no estatico)\n");
            foreach (Vehiculo item in lavadero.GetVehiculos)
            {
                Console.WriteLine(item); //item.ToString(); //item.Mostrar();
            }

            //Estatico
            lavadero.GetVehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);

            Console.WriteLine("\nOrdenado por patente (Metodo estatico)\n");
            foreach (Vehiculo item in lavadero.GetVehiculos)
            {
                Console.WriteLine(item); //item.ToString(); //item.Mostrar();
            }

            if ((auto.Equals(auto)))
            {
                Console.WriteLine("\nSon iguales\n");
            }
            else
            {
                Console.WriteLine("\nSon diferentes\n");
            }

            Console.WriteLine(lavadero.GetLavadero);

            Console.ReadLine();
        }
    }
}
