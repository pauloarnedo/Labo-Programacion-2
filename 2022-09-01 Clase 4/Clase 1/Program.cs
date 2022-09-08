using Entidades;
using System.Security;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sum1 = new Sumador(17);
            Sumador sum2 = new Sumador(20);

            Console.WriteLine(sum1.Sumar("Hola", "que tal"));
            Console.WriteLine(sum1.Sumar(150, 43));
            Console.WriteLine(sum1.cantidadSumas);
            Console.WriteLine("");
            Console.WriteLine(sum1 + sum2);
            Console.WriteLine(sum1 | sum2);
            Console.WriteLine((int)sum2);

        }
    }
}