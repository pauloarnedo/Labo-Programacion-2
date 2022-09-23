using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Ej2
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            if (totalGoles == 0 || partidosJugados == 0)
            {
                return 0;
            }
            else
            {
                this.promedioGoles = totalGoles / partidosJugados;
                return promedioGoles;
            }
        }

        private Jugador()
        {
            this.dni = 0;
            this.nombre = "";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            float prom = this.GetPromedioGoles();
            string datos = "DNI: " + this.dni + " | Nombre: " + this.nombre + " | Partidos Jugados: " + this.partidosJugados + " | Total de Goles: " + this.totalGoles + " | Promedio Goles: " + prom;
            return datos;
        }
    }
}
