using Entidades;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Paulo Arnedo", 150000);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Retirar(43200);
            cuenta1.Ingresar(25000);
        }
    }
}