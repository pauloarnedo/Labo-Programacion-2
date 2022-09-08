using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_08_25_Ejercicio_1
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool confirmacion;
            if(valor < min || valor > max)
            {
                confirmacion = false;
            }
            else
            {
                confirmacion = true;
            }
            return confirmacion;
        }
    }
}
