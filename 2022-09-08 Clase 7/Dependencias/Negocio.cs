using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente 
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                _ = this + value;
            } 
        }

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            /*ENTENDER ESTA LINEA DE CÓDIGO*/
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool clienteEnColeccion = n.clientes.Contains(c);
            return clienteEnColeccion;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            bool clienteNoEnColeccion = !(n == c);
            return clienteNoEnColeccion;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            
            if(n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if(n.ClientesPendientes > 0)
            {
                /*ENTENDER ESTA LÍNEA DE CÓDIGO*/
                retorno = n.caja.AtenderCliente(n.Cliente);
            }

            return retorno;
        }

        public int ClientesPendientes
        {
            get
            {
                return clientes.Count;
            }
        }
    }
}
