using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ej1_Entidades.VehiculoTerrestre;

namespace Ej1_Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;
        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }

        public void MostrarData()
        {
            Console.WriteLine("Ruedas: " + this.cantidadRuedas + " | Puertas: " + this.cantidadPuertas + " | Color: " + this.color + " | Peso Carga: " + this.pesoCarga);
        }
    }
}
