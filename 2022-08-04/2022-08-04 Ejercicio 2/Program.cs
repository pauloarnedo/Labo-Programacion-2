namespace _2022_08_04_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            int numero;
            int cuadrado;
            int cubo;
            bool parse;

            Console.Write("Ingrese un número: ");
            ingreso = Console.ReadLine();
            /*numero = int.Parse(ingreso);*/
            bool sePueParsear = int.TryParse(ingreso, out numero);

            while(numero <= 0)
            {
                Console.WriteLine("");
                Console.Write("Ingrese un número distinto de 0: ");
                ingreso = Console.ReadLine();
                numero = int.Parse(ingreso);
            }

            cuadrado = numero * numero;
            cubo = numero * cuadrado;
            Console.WriteLine("Número al cuadrado: {0}", cuadrado);
            Console.WriteLine("Número al cubo: {0}", cubo);
        }
    }
}