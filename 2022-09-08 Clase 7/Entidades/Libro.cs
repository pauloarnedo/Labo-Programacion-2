namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;
        
        public Libro()
        {
            this.paginas = new List<string>();
        }
        
        public string this[int i]
        {
            get
            {
                string retorno = "";
                
                if(i > 0 && i < paginas.Count)
                {
                    retorno = paginas[i];
                }

                return retorno;
            }

            set
            {
                if(i > 0)
                {
                    if (i < paginas.Count)
                    {
                        paginas[i] = value;
                    }
                    else
                    {
                        paginas.Add(value);
                    }
                }
            }
        }

    }
}