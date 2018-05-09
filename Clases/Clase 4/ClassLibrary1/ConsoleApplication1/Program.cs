using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa valores = new Cosa();

            valores.EstablecerValor(55);
            valores.EstablecerValor("Mario");
            valores.EstablecerValor(DateTime.Now);

            DateTime nacimiento = new DateTime(1998,7,8);

            Cosa test = new Cosa(19, "Juan",  nacimiento);
            Console.WriteLine("{0}\n", test.Mostrar());
            //Console.WriteLine("Entero: {0}, Cadena: {1}, Fecha {2}", test.entero, test.cadena, test.fecha);

            Cosa test2 = new Cosa(99999);
            Console.WriteLine("{0}\n", test2.Mostrar());


            Console.WriteLine("{0}\n", valores.Mostrar());
            //Console.WriteLine("Entero: {0}, Cadena: {1}, Fecha {2}", valores.entero, valores.cadena, valores.fecha);

            
            Console.ReadLine();

           
        }
    }
}
