using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase9Herencia
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;

        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public string GetLavadero
        {
            get 
            {
                string cadena = "Precio auto: " + this._precioAuto + " - Precio camion: " + this._precioCamion + " - Precio moto: " + this._precioMoto + "\n\n";

                foreach (Vehiculo v in this._vehiculos)
                {
                    cadena += v.ToString() +  " - " + v.Acelerar() + "\n";
                }

                return cadena;
            }
        }

        public List<Vehiculo> GetVehiculos
        {
            get { return this._vehiculos;}
        }

        public double MostrarTotalFacturado()
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado(EVehiculos vehiculos)
        {
            double facturado = 0;
            int cont_a = 0, cont_c = 0, cont_m = 0;

            foreach (Vehiculo v in this._vehiculos)
            {
                if (v is Auto && vehiculos == EVehiculos.Auto)
                {
                    cont_a++;
                }
                else if (v is Camion && vehiculos == EVehiculos.Camion)
                {
                    cont_c++;
                }
                else if (v is Moto && vehiculos == EVehiculos.Moto)
                {
                    cont_m++;
                }

            }

            switch (vehiculos)
            {
                case EVehiculos.Auto:
                    facturado = (cont_a * this._precioAuto);
                    break;
                case EVehiculos.Camion:
                    facturado = (cont_c * this._precioCamion);
                    break;
                case EVehiculos.Moto:
                    facturado = (cont_c * this._precioMoto);
                    break;
            }

            return facturado;
        }

        public static bool operator ==(Lavadero lavadero, Vehiculo vehiculo)
        {
            bool retorno = false;

            foreach (Vehiculo v in lavadero._vehiculos)
            {
                if(v == vehiculo)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero lavadero, Vehiculo vehiculo)
        {
            return !(lavadero == vehiculo);
        }

        public static Lavadero operator +(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero != vehiculo)
            {
                lavadero._vehiculos.Add(vehiculo);
            }

            return lavadero;
        }

        public static Lavadero operator -(Lavadero lavadero, Vehiculo vehiculo)
        {
            if (lavadero == vehiculo)
            {
                lavadero._vehiculos.Remove(vehiculo);
            }

            return lavadero;
        }

        //Lavadero.
        public static int OrdenarVehiculosPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            int retorno = string.Compare(vehiculo1.Patente, vehiculo2.Patente);
            return retorno;
        }

        //objLavadero.
        public int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            int retorno = string.Compare( vehiculo1.Marca.ToString() , vehiculo2.Marca.ToString() );
            return retorno;
        }
    }
}
