namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string test;
            test = Console.ReadLine();
            Console.WriteLine("la respuesta es {0} ",test);
            foreach(char item in test) { Console.WriteLine(item); }

            /*declaro un array, new int[] setea el tamaño de dicho array.*/
            int[] unArray = new int[8];
        }
    }
}