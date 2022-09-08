using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        private Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Euro(Dolar d)
        {

        }

        public static explicit operator Pesos(Dolar d)
        {

        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        /*public static implicit operator Dolar(double d)
        {
            return d.cantidad;
        }*/

        public static bool operator !=(Dolar d, Euro e)
        {

        }

        public static bool operator !=(Dolar d, Pesos p)
        {

        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {

        }

        public static Dolar operator -(Dolar d, Euro e)
        {

        }

        public static Dolar operator -(Dolar d, Pesos p)
        {

        }

        public static Dolar operator +(Dolar d, Euro e)
        {

        }

        public static Dolar operator +(Dolar d, Pesos p)
        {

        }

        public static bool operator ==(Dolar d, Euro e)
        {

        }

        public static bool operator ==(Dolar d, Pesos p)
        {

        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {

        }

    }
}
