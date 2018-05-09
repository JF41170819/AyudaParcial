using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace TestTinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta objTinta0 = new Tinta();
            Tinta objTinta1 = new Tinta();
            Tinta objTinta2 = new Tinta(ETipoTinta.china);
            Tinta objTinta3 = new Tinta(ConsoleColor.Blue, ETipoTinta.conBrillito);

            string mostrar1 = Tinta.Mostrar(objTinta1);
            string mostrar2 = Tinta.Mostrar(objTinta2);
            string mostrar3 = Tinta.Mostrar(objTinta3);
            Console.WriteLine("----------------------------\nTINTA 1: {0}\nTINTA 2: {1}\nTINTA 3: {2}\n---------------------------\n", mostrar1, mostrar2, mostrar3);

            if (objTinta1 != objTinta2)
            {
                Console.WriteLine("Tinta1 y Tinta2 son diferentes\n");
            }

            if (objTinta0 == objTinta1)
            {
                Console.WriteLine("Tinta0 y Tinta1 son iguales\n");
            }

            Pluma objPluma0 = new Pluma();
            Pluma objPluma1 = new Pluma("Parker");
            Pluma objPluma2 = new Pluma("Parker", objTinta0);
            Pluma objPluma3 = new Pluma("Parker", objTinta1, 45);

            string mostrarPluma = objPluma2;

            Console.WriteLine("{0}\n", mostrarPluma);

            if (objPluma2 == objTinta0)
            {
                Console.WriteLine("objPluma2 es igual a objTinta0\n");

                objPluma2 = objPluma2 - objTinta0;

                string mostrarPluma2 = objPluma2;

                Console.WriteLine("{0}\n", mostrarPluma2);

            }

            
            Console.ReadLine();
        }
    }
}
