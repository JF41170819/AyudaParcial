using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tinta
    {
        ConsoleColor color;
        ETipoTinta tipoTinta;


        //Constructor parametrizado - SOBRECARGA 1
        /// <summary>
        /// Constructor del objeto tinta.
        /// </summary>
        /// <param name="color">Parametro que inicializará un color/param>
        /// <param name="tipoTinta">Parametro que inicializará un tipo de tinta</param>
        public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
        {
            this.color = color;
            this.tipoTinta = tipoTinta;
        }
        //Constructor - SOBRECARGA 2
        /// <summary>
        /// Constructor del objeto tinta.
        /// </summary>
        public Tinta():this(ConsoleColor.Black, ETipoTinta.comun)
        {
        }

        //Constructor - SOBRECARGA 2
        /// <summary>
        /// Constructor del objeto tinta.
        /// </summary>
        /// /// <param name="tipoTinta">Parametro que inicializará un tipo de tinta</param>
        public Tinta(ETipoTinta tipoTinta): this()
        {
            this.tipoTinta = tipoTinta;
        }

        private string Mostrar()
        {
            return this.color + " - " + this.tipoTinta;
        }

        public static string Mostrar(Tinta tipoTinta)// NO USAR THIS EN METODOS ESTATICOS
        {
            return tipoTinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            bool retorno = false;

            if (tinta1.color == tinta2.color && tinta1.tipoTinta == tinta2.tipoTinta)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }
    }
}
