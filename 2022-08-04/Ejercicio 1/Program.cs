namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txtIngreso;
            int numIngreso;
            int mayor;
            int menor;
            int sumPromedio = 0;
            int promedio;
            int cantidadIngreso = 5;

            for (int i = 0; i < cantidadIngreso; i++)
            {
                Console.Write("ingrese un número: ");
                txtIngreso = Console.ReadLine();
                numIngreso = int.Parse(txtIngreso);
                
                if (i == 0)
                {
                    mayor = numIngreso;
                    menor = numIngreso;
                }
                else
                {
                    if(numIngreso < menor)
                    {
                        menor = numIngreso;
                    }
                    if(numIngreso > mayor)
                    {
                        mayor = numIngreso;
                    }

                }
                sumPromedio += numIngreso;
            }
            promedio = sumPromedio / cantidadIngreso;

            Console.WriteLine("Numero Máximo : {0}", mayor);
            Console.WriteLine("Numero Mínimo : {0}", menor);
            Console.WriteLine("Promedio : {0}", promedio);

        }
    }
}