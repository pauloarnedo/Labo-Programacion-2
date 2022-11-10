/*
delegados: cuando le quiero pasar una funcion a una funcion. Como no puedo hacer eso tengo que usar un delegado. Guarda la ref al metodo y a la instancia que lo invocó.

se declara con la palabra reservada delegate.
tiene firma pero no contenido

a partir de este delegado puedo llamar cualquier otro método que tenga la misma firma
*/

namespace Práctica_en_clase
{
    internal class Program
    {
        public delegate string MiDelegado();
        public delegate void DelegadoSinRetornoNiParametros();
        public delegate string DelegadoConUnParametro(string mensaje);
        //public delegate void DelegadoConDosParametros(string nombre, int edad);
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pedro", 22);
            Persona p2 = new Persona("Juan", 33);
            Persona p3 = new Persona("Marcos", 44);

            //instancio el delegado. Le paso el puntero del metodo que voy a usar.
            MiDelegado delegadito = new MiDelegado(p1.SaludarConDni);

            //llamo al delegado.
            Console.WriteLine(delegadito());
            
            //apunto a otro método.
            delegadito = p1.SaludarSinParametros;
            Console.WriteLine(delegadito());

            /**********/

            DelegadoConUnParametro delegadoParametro = p2.SaludarConMensaje;
            Console.WriteLine(delegadoParametro("Saludos a la flia..."));


            
            
            
            
            
            
            
            
            MiDelegadoComparador delegadoComparador = MiFuncionMayor;
            List<int> listaEnteros = new List<int>()
            {
             5,8,12,99,22,5,1223,54,88,7887,8
            };


            Console.WriteLine( "el num mayor es " + p1.FuncionConDelegado(delegadoComparador, listaEnteros));

            delegadoComparador = MiFuncionMenor;
            Console.WriteLine("el num menor es " + p1.FuncionConDelegado(delegadoComparador, listaEnteros));

        }

        static bool MiFuncionMayor(int num1, int num2)
        {
            if(num1 < num2)
            {
                return true;
            }
            else { return false; }
        }

        static bool MiFuncionMenor(int num1, int num2)
        {
            if (num1 > num2)
            {
                return true;
            }
            else { return false; }
        }
    }
}