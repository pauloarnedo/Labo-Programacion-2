using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public string GetTitular()
        {
            return titular;
        }

        public float GetCantidad()
        {
            return cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razón social: " + GetTitular());
            sb.AppendLine("Dinero en cuenta: " + GetCantidad());

            return sb.ToString();
        }

        public void Ingresar(int monto)
        {
            if(monto > 0)
            {
                cantidad += monto;
                Console.WriteLine("Monto Ingresado: " + monto + "\nDinero en cuenta: " + cantidad);
            }
            else
            {
                Console.WriteLine("No se pueden ingresar valores negativos");
            }
        }

        public void Retirar(int monto)
        {
            if (monto > 0)
            {
                cantidad -= monto;
                Console.WriteLine("Monto retirado: " + monto + "\nDinero en cuenta: " + cantidad);
            }
        }

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
    }
}