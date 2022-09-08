using System.Drawing;
using System.Runtime.Intrinsics;

namespace Entidades
{
    public class Vehiculo
    {
        private string marca;
        private int puertas;
        private string color;
        private int litrosNafta;

        public Vehiculo(int puertas)
        {
            this.puertas = puertas;
            this.marca = "asdads";
            this.color = "adsasdas";
            this.litrosNafta = 1000;
        }

        public Vehiculo(string marca, int puertas) : this(puertas)
        {
            this.marca = marca;
        }

        public Vehiculo(string marca, int puertas, string color) : this(marca, puertas)
        {
            this.color = color;
        }

        public Vehiculo(string marca, int puertas, string color, int litrosNafta) : this(marca, puertas, color)
        {
            this.litrosNafta = litrosNafta;
        }

        public string Color 
        {
            get { return this.color; } 
            set { this.color = value; } 
        }

        public static int operator +(Vehiculo n1, Vehiculo n2)
        {
            return n1.litrosNafta + n2.litrosNafta;
        }

        //Si sobrecargo == tengo que sobrecargar !=
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return v1.color == v2.color;
        }
        
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public static implicit operator string(Vehiculo v1)
        {
            return v1.color;
        }

        public static explicit operator int(Vehiculo v1)
        {
            return v1.litrosNafta;
        }
            
    }
}