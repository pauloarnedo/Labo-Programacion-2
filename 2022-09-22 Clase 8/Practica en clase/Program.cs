using Entidades;

namespace Practica_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Mascota mascota = new Mascota("Mascota", 8, "Femenino");
            Perro cusco = new Perro("Coco", 3, "Masculino");
            Perro deRaza = new Perro("Loly", 4, "Femenino", "Caniche");

            Gato g1 = new Gato("Michi", 5, "Femenino");

            Cachorro chicho = new Cachorro("chicho", 6, "M");
            Console.WriteLine(chicho.Ladrar());

            //Console.WriteLine(mascota.Saludar());

            Console.WriteLine(cusco.Ladrar());
            Console.WriteLine(cusco.Saludar());
        }
    }
}