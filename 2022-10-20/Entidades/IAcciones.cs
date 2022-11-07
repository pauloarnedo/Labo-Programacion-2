using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAcciones
    {
        ConsoleColor Color
        {
            set;
            get;
        }

        float UnidadesDeEscritura
        {
            //test 2
            get;
            set;
        }

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidades);
    }
}
