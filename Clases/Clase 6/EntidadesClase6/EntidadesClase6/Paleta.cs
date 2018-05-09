using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase6
{
    class Paleta
    {
        private Tempera[] colores_Array;
        private int CantidadMaximaColores;

        private Paleta(int cantidad)
        {
            this.CantidadMaximaColores = cantidad;
            this.colores_Array = new Tempera[cantidad];
        }

        private Paleta()
            : this(5)
        {

        }

        public static implicit operator Paleta(int cantidad)
        {
            Paleta objPaleta = new Paleta(cantidad);
            return objPaleta;
        }

        private string Mostrar()
        {
            string retorno = "Cantidad maxima de colores: " + this.CantidadMaximaColores + "\n";

            for (int i = 0; i < this.CantidadMaximaColores; i++)
            {
                if (this.colores_Array.GetValue(i) != null)
                {
                    retorno += Tempera.Mostrar(this.colores_Array[i]) + "\n";
                }
            }

            return retorno;

        }

        public static explicit operator string(Paleta objPaleta)
        {
            return objPaleta.Mostrar();
        }

        public static bool operator ==(Paleta objPaleta, Tempera objTempera)
        {
            bool retorno = false;

            for (int i = 0; i < objPaleta.CantidadMaximaColores; i++)
            {
                if (objPaleta.colores_Array.GetValue(i) != null)
                {
                    if (objPaleta.colores_Array[i] == objTempera)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        public static bool operator !=(Paleta objPaleta, Tempera objTempera)
        {
            return !(objPaleta == objTempera);
        }

        public static Paleta operator +(Paleta objPaleta, Tempera objTempera)
        {
            if (objPaleta == objTempera)
            {
                int indice1 = objPaleta.ObtenerIndice(objTempera);

                objPaleta.colores_Array[indice1] += objTempera;
            }
            else if (objPaleta != objTempera)
            {
                int indice2 = objPaleta.ObtenerIndice();

                objPaleta.colores_Array[indice2] += objTempera;
            }

            return objPaleta;
        }

        private int ObtenerIndice()
        {
            int indice = -1;

            for (int i = 0; i < this.CantidadMaximaColores; i++)
            {
                if ((object)this.colores_Array[i] == null) //this.colores_Array.GetValue(i)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        private int ObtenerIndice(Tempera objTempera)
        {
            int indice = -1;

            for (int i = 0; i < this.CantidadMaximaColores; i++)
            {
                if (this.colores_Array[i] == objTempera)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }

        public static Paleta operator -(Paleta objPaleta, Tempera objTempera)
        {
            if (objPaleta == objTempera)
            {
                int indice1 = objPaleta.ObtenerIndice(objTempera);

                if (indice1 > 0)
                {
                    objPaleta.colores_Array[indice1] += -(objTempera);

                    if (objPaleta.colores_Array[indice1] <= 0)
                    {
                        objPaleta.colores_Array[indice1] = null;
                    }
                }
            }

            return objPaleta;

        }

        //Operador sobrecarga +, sumar las paletas.

        public static Paleta operator +(Paleta objPaleta, Tempera objTempera)
        {
            if (objPaleta == objTempera)
            {
                int indice1 = objPaleta.ObtenerIndice(objTempera);

                if (indice1 > 0)
                {
                    objPaleta.colores_Array[indice1] += (objTempera);

                    if (objPaleta.colores_Array[indice1] <= 0)
                    {
                        objPaleta.colores_Array[indice1] = null;
                    }
                }
            }

            return objPaleta;
        }

    }
}
