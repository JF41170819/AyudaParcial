using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public class Auto : Vehiculo
    {
        protected int _cantidadAsientos;

        public string MostrarAuto()
        {
            return base.Mostrar() + " - Cantidad de asientos: " + this._cantidadAsientos;
        }

        public Auto(int cantidadAsientos, string patente, byte cantRuedas, EMarcas marca):base(patente, cantRuedas, marca)
        {
            this._cantidadAsientos = cantidadAsientos;
        }
    }
}
