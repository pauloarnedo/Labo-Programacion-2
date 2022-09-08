using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1___Práctica_en_clase
{
    public class Animal
    {
        public string nombre;
        public int edad;
        public string tipoDeAnimal;
        public static int contadorDeAnimales;

        static Animal()
        {
            contadorDeAnimales = 0;
        }
       
        public Animal()
        {
            Animal.contadorDeAnimales++;
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.tipoDeAnimal = "Desconocido";
        }

        public Animal(string nombre, int edad, string tipoDeAnimal)
        {
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;
        }

        public string Hablar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Mi nombre es ");
            sb.AppendLine(this.nombre);
            sb.Append(", tengo ");
            sb.AppendLine(this.edad.ToString());
            sb.Append(" años de edad y soy un ");
            sb.AppendLine(this.tipoDeAnimal);

            return sb.ToString();
        }

    }
}
