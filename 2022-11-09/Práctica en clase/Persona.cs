using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_en_clase
{
    //Si al delegado solo lo voy a usar en la clase, lo creo en la clase.
    //Si necesito usarlo en más lugares lo creo en el namespace, por fuera de la clase.
    public delegate bool MiDelegadoComparador(int num1, int num2);
    public class Persona
    {
        public string nombre;
        public int edad;
        public Persona(string nombre, int edad)
        {
            this.edad = edad;
            this.nombre = nombre;
        }

        public string SaludarSinParametros()
        {
            return nombre;
        }

        public string SaludarConDni()
        {
            return "Hola mi dni es " + this.edad.ToString();
        }

        public string SaludarConMensaje(string msg)
        {
            return "el mensaje es " + msg;
        }

        public int FuncionConDelegado(MiDelegadoComparador comparador, List<int> listaEneteros)
        {
            //Normalmente los delegados se crean dentro de la clase.
            int aux = listaEneteros[0];
            for(int i=0;i < listaEneteros.Count; i++)
            {
                if(comparador(aux, listaEneteros[i]))
                {
                    aux = listaEneteros[i];
                }
            }
            return aux;
        }
    }
}
