using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_en_clase
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion() : base("Lanzaste excepcion por defecto")
        {
        }

        public MiExcepcion(string message) : base(message)
        {
        }

        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
