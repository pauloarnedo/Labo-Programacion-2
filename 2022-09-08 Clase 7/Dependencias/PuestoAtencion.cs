using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }

        public bool AtenderCliente(Cliente cli)
        {
            bool retorno = false;

            if(!(cli is null) && cli.Numero > 0)
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(800);
                }
                retorno = true;
            }

            return retorno;
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            /*ENTENDER ESTA LÍNEA DE CÓDIGO*/
            this.puesto = puesto;
        }

    }
}
