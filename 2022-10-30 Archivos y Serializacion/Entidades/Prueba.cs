using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prueba
    {
        private string nombre;
        private int edad;
        private string puesto;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public string Puesto { get { return puesto; } set { puesto = value; } }

        public Prueba()
        {
            Nombre = "";
            Edad = 0;
            Puesto = "";
        }
        public Prueba(string nombre, int edad, string puesto)
        {
            Nombre = nombre;
            Edad = edad;
            Puesto = puesto;
        }
    }
}
