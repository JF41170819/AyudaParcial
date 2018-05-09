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
            Moto moto = new Moto(1, "GHI789", 2, EMarcas.Honda);

            lavadero += camion;
            lavadero += auto;
            lavadero += moto;

            //No estatico (de instancia)
            lavadero.GetVehiculos.Sort(lavadero.OrdenarVehiculosPorMarca);
            //Estatico
            //lavadero.GetVehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);

            foreach (Vehiculo vec in lavadero.GetVehiculos)
            {
                if (vec is Auto)
                {
                    Console.WriteLine("{0}\n", ((Auto)vec).MostrarAuto());
                }
                else if (vec is Moto)
                {
                    Console.WriteLine("{0}\n", ((Moto)vec).MostrarMoto());
                }
                else if (vec is Camion)
                {
                    Console.WriteLine("{0}\n", ((Camion)vec).MostrarCamion());
                }
            }
            



            Console.ReadLine();
        }
    }
}
