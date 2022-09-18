using Entidades;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();
            
            libro[1] = "Loro";
            libro[2] = "Gato";
            libro[3] = "Sapo";
            libro[4] = "Rino";

            Console.WriteLine(libro[8]);
        }
    }
}