using Entidades;
using System.Drawing;

namespace Práctica_en_clase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string color;
            int ln;
            
            Vehiculo v1 = new Vehiculo(5);
            Vehiculo v2 = new Vehiculo("adas", 5);
            Vehiculo v3 = new Vehiculo("adas", 5, "rojo");
            Vehiculo v4 = new Vehiculo("adas", 5, "rojo", 100);

            v2.Color = "rojo";
            v1.Color = v2.Color;

            Console.WriteLine(v1 + v2);

            color = v1;
            ln = (int)v1;
        }
    }
}