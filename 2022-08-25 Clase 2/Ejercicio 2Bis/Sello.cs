using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2Bis
{
    internal class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir() { return Sello.ArmarFormatoMensaje(); }
        public static void Borrar() { Sello.mensaje = ""; }

        public static string ArmarFormatoMensaje()
        {
            string mensajeFinal = "";
            foreach (char item in Sello.mensaje)
            {
                mensajeFinal += "*";
            }
            mensajeFinal += "**\n*";
            mensajeFinal += Sello.mensaje;
            mensajeFinal += "*\n**";
            foreach (char item in Sello.mensaje)
            {
                mensajeFinal += "*";
            }
            return mensajeFinal;
        }

        public static void ImprimirEnColor() 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }
    }
}
