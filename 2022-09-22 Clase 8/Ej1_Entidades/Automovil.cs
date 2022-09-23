using static Ej1_Entidades.VehiculoTerrestre;

namespace Ej1_Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private int cantidadPasajeros;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}