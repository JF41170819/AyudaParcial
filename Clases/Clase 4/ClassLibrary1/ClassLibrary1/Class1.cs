using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cosa
    {
        //Atributos no estáticos, accedo desde la instancia de la clase.
        public int entero;
        public string cadena;
        public DateTime fecha;

        //Metodo original (Firma del metodo)
        /// <summary>
        /// Establecer un valor para algún atributo de la clase.
        /// </summary>
        /// <param name="entero">Parametro que inicializará un entero</param>
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        //Sobrecarga 1
        /// <summary>
        /// Establecer un valor para algún atributo de la clase.
        /// </summary>
        /// <param name="cadena">Parametro que inicializará una cadena</param>
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        //Sobrecarga 2
        /// <summary>
        /// Establecer un valor para algún atributo de la clase.
        /// </summary>
        /// <param name="fecha">Parametro que inicializará una fecha</param>
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        //Metodo mostrar
        /// <summary>
        /// Retorna un string concatenado con los datos del entero, cadena, fecha.
        /// </summary>
        public string Mostrar()
        {
            string retorno = "" + this.entero + "\n" + this.cadena + "\n" + this.fecha;
            return retorno;

        }

        //Constructor
        /// <summary>
        /// Constructor del objeto cosa.
        /// </summary>
        public Cosa():this(10,"Sin valor", DateTime.Now) //No sirve para metodos solo constructores
        {
            /*this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;*/
        }

        //Constructor parametrizado - SOBRECARGA 1
        /// <summary>
        /// Constructor del objeto cosa parametrizado.
        /// </summary>
        /// <param name="entero">Parametro que inicializará un entero</param>
        /// <param name="cadena">Parametro que inicializará una cadena</param>
        /// <param name="fecha">Parametro que inicializará una fecha</param>
        public Cosa(int entero, string cadena, DateTime fecha)
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = fecha;
        }

        //Constructor parametrizado - SOBRECARGA 2
        /// <summary>
        /// Constructor del objeto cosa parametrizado (con 2 parametros).
        /// </summary>
        /// <param name="entero">Parametro que inicializará un entero</param>
        /// <param name="cadena">Parametro que inicializará una cadena</param>
        public Cosa(int entero, string cadena) //:this(entero,cadena,DateTime.Now), NO AHORRO CODIGO, DEBERIA ANULAR CONSTRUCTOR 2 O 3
        {
            this.entero = entero;
            this.cadena = cadena;
            this.fecha = DateTime.Now;
        }

        //Constructor parametrizado - SOBRECARGA 3
        /// <summary>
        /// Constructor del objeto cosa parametrizado (con 1 parametro).
        /// </summary>
        /// <param name="entero">Parametro que inicializará un entero</param>
        public Cosa(int entero) //:this(entero,"Sin valor", DateTime.Now), NO AHORRO CODIGO, DEBERIA ANULAR CONSTRUCTOR 2 O 3
        {
            this.entero = entero;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        //En C# se puede llamar desde una sobrecarga llamar al constructor original u otra sobrecarga
    }
}
