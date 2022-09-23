using Entidades_Ej2;
namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Jugador j1 = new Jugador(1234, "carlos", 50, 42);
            Console.WriteLine(j1.MostrarDatos());
        }
    }
}