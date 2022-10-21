namespace Practica_en_clase
{
    internal class Program
    {
        // No se valida más con if. Se valida con excepciones.
        // Parece que se usa para facilitar el laburo del programador.
        // Como mucho se usan dos excepciones. Sino se usa exception directamente.
        static void Main(string[] args)
        {
            int numero = 0;
            try
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch(OverflowException ex)
            {
                Console.Write("Error: ");
                Console.WriteLine(ex.Message);

                // Leer bien qué hace el throw.
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            catch(DivideByZeroException ex)
            {
                Console.Write("Error: no se puede dividir por cero");
            }
            catch (Exception ex)
            {
                Console.Write("Error: ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Haya excepción o no, esto siempre se ejecuta.
                // "Llamo un método y ese método tira una excepción".
                Console.WriteLine(numero);
            }
        }
    }
}