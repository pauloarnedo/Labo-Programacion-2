namespace Combinatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            En el main sólo poner el menu principal para chequear qué operacion se desea realizar
            Armar otra clase llamada "operaciones" para pedir el ingreso de los números según la operacion
            dentro de operaciones, agregar un método que pida el ingreso de un dato, lo revise y cuando esté ok lo devuelva a la operación
            al final del cálculo de la operación, borrar todo de consola, poner el tipo de operacion, los valores y el resultado
            ej: Variación - V 4,2 = 12
            */
            
            int numIngreso = 0;

            var listaIngresos = new List<int>();
            numIngreso = int.Parse(Console.ReadLine());
            while (numIngreso > 0)
            {
                listaIngresos.Add(numIngreso);
                numIngreso = int.Parse(Console.ReadLine());
            }
            var valores = listaIngresos.ToArray();
            Console.WriteLine(Matematica.PermutacionCompuesta(valores));

        }
    }
}