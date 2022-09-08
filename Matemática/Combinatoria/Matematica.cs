using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinatoria
{
    public static class Matematica
    {
        private static int resultado;
        public static int Factoreo(int n)
        {
            for(int i = n-1; i > 1; i--)
            {
                n *= i;
            }
            return n;
        }

        public static int Potencia(int n, int p)
        {
            Matematica.resultado = n;
            for(int i = 2; i <= p; i++)
            {
                Matematica.resultado *= n;
            }
            return Matematica.resultado;
        }

        public static int PermutacionSimple(int n)
        {
            Matematica.resultado = Matematica.Factoreo(n);
            return Matematica.resultado;
        }

        public static int VariacionSimple(int n, int k)
        {
            Matematica.resultado = Matematica.Factoreo(n) / Matematica.Factoreo(n - k);
            return Matematica.resultado;
        }

        public static int CombinacionSimple(int n, int k)
        {
            Matematica.resultado = (Matematica.Factoreo(n)) / (Matematica.Factoreo(k) * Matematica.Factoreo(n - k));
            return Matematica.resultado;
        }

        public static int PermutacionCompuesta(int[] valores)
        {
            int suma = 0;
            int productoFactoreados = 1;

            for (int i = 0; i < valores.Count(); i++)
            {
                suma += valores[i];
                productoFactoreados *= Matematica.Factoreo(valores[i]);
            }
            Matematica.resultado = Matematica.Factoreo(suma) / productoFactoreados;
            return Matematica.resultado;
        }

        public static int VariacionCompuesta(int n, int k)
        {
            Matematica.resultado = Matematica.Potencia(n, k);
            return Matematica.resultado;

        }

        public static int CombinacionCompuesta(int n, int k)
        {
            Matematica.resultado = Matematica.Factoreo(n - k - 1) / Matematica.Factoreo(n - 1) * Matematica.Factoreo(k);
            return Matematica.resultado;
        }
    }
}
