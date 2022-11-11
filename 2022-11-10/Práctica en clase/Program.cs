namespace Práctica_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() =>
            {
                try
                {
                    throw new Exception("Desde el hilo 1 tiro la excepcion");
                }
                catch (Exception)
                {
                    Console.WriteLine("Desde adentro del catch 1");
                }
            });
            Task t2 = new Task(() =>
            {
                //throw new Exception("Desde el hilo 2 tiro la excepcion");
                Console.WriteLine("Desde adentro del try 2");
            });

            t1.Start();
            t2.Start();
            Console.WriteLine("Fin del programa");
        }
    }
}