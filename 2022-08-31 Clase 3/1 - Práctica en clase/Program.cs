namespace _1___Práctica_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string nombre;

            Animal animal1;
            Animal animal2;

            /*instancio un objeto de tipo animal*/
            /*reservo el espacio de memoria del tamaño de animal*/
            animal1 = new Animal("Pepe", 10, "Perro");
            animal2 = new Animal(); 
            animal2.edad = 5;
            animal2.tipoDeAnimal = "Gato";

            Console.WriteLine(animal1.Hablar());
            Console.WriteLine(animal2.Hablar());

            Console.WriteLine(Animal.contadorDeAnimales);
        }
    }
}