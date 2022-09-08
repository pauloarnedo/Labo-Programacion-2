namespace _2022_08_04_Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ingreso, decision;
            int numIngresado, n, i, m = 0;
            bool flag, verifIngreso;
            bool seguir;
            seguir = true;
            while (seguir == true)
            {
                do
                {
                    Console.Write("Ingrese un número: ");
                    ingreso = Console.ReadLine();
                    verifIngreso = int.TryParse(ingreso, out numIngresado);
                    if (ingreso == "salir")
                    {
                        return;
                    }
                }
                while (verifIngreso == false);


                for (n = 1; n < numIngresado; n++)
                {
                    flag = false;
                    m = n / 2;
                    for (i = 2; i <= m; i++)
                    {
                        if (n % i == 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false)
                    {
                        Console.WriteLine(n);
                    }
                }
                do
                {
                    Console.Write("\nDesea Seguir? (y/n): ");
                    decision = Console.ReadLine();
                }
                while (decision != "y" && decision != "n");

                if(decision == "y") { seguir = true; }
                if(decision == "n") { seguir = false; }
            }
        }
    }
}