using Ej1_Entidades;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion c1 = new Camion(4, 3, Colores.Blanco, 5, 5000);
            c1.MostrarData();
        }
    }
}