using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public /*sealed*/ class Perro : Mascota
    {
        private string raza;
        public Perro(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {
        }

        public Perro(string nombre, int patas, string sexo, string raza) : this(nombre, patas, sexo)
        {
            this.raza = raza;
        }

        public string Ladrar()
        {
            return this.nombre + "GUAU";
        }
    }

    public class Cachorro : Perro
    {
        public Cachorro(string nombre, int patas, string sexo) : base(nombre, patas, sexo)
        {
            this.nombre = nombre;
        }
    }
}
