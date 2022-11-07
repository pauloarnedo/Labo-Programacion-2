using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL
{
    public class Empleado
    {
        public int id_empleado;
        public string nombre;
        public string apellido;
        public int id_puesto;
        public double salario;
        public bool estaActivo;
        public string fecha_alta;

        public Empleado(int id_empleado, string nombre, string apellido, int id_puesto, double salario, bool estaActivo, string fecha_alta)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id_puesto = id_puesto;
            this.salario = salario;
            this.estaActivo = estaActivo;
            this.fecha_alta = fecha_alta;
        }
    }
}
