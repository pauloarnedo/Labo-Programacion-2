namespace _2022_08_25_Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtIngresado;
            int numIngresado = 0;
            int cantVueltas = 10;
            int minimo = 0;
            int maximo = 0;
            int suma = 0;
            int promedio;
            bool parse;
            bool validacion = false;
            
            for(int i = 0; i < cantVueltas; i++)
            {
                do
                {
                    do
                    {
                        Console.Write("Ingrese Número {0}: ", i+1);
                        txtIngresado = Console.ReadLine();
                        parse = int.TryParse(txtIngresado, out numIngresado);
                    }
                    while (!parse);
                    validacion = Validador.Validar(numIngresado, -100, 100);
                }
                while (!validacion);
                
                suma += numIngresado;

                if (i == 0)
                {
                    minimo = numIngresado;
                    maximo = numIngresado;
                }
                else
                {
                    if (numIngresado < minimo)
                    {
                        minimo = numIngresado;
                    }
                    else if (numIngresado > maximo)
                    {
                        maximo = numIngresado;
                    }
                } 
            }

            promedio = suma / cantVueltas;

            Console.WriteLine("\nSuma: {3} \nPromedio: {0} \nMinimo: {1} \nMaximo: {2}", promedio, minimo, maximo, suma);

        }
    }
}