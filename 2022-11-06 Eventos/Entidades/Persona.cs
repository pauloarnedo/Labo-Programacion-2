namespace Entidades
{

    public delegate void DelegadoString(string texto);
    public class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido { 
            get { 
                return apellido; 
            } 
            set { 
                apellido = value;
                if(EventoString is not null)
                {
                    EventoString.Invoke("se cambió el apellido a " + apellido);
                }
            } 
        }
        public string Nombre { 
            get { 
                return nombre; 
            } 
            set { 
                nombre = value;
                if (EventoString is not null)
                {
                    EventoString.Invoke("se cambió el nombre a " + nombre);
                }
            }
        }

        public Persona()
        {
            
        }

        public string Mostrar()
        {
            return nombre+" "+apellido;
        }

        public event DelegadoString EventoString;
    }
}