﻿namespace Ejercicio_2Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "hola mundo";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());
        }
    }
}