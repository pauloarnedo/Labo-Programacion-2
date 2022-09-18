﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre
        {
            /*armar getter y setter*/
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;            
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) : this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}