using Entidades;
namespace Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prueba e1 = new Prueba("José", 48, "Encargado");
            SerialXML<Prueba> listado = new SerialXML<Prueba>();
            listado.Serializar(e1, "C:\\Users\\Paulo\\Desktop\\prueba.xml");
        }
    }
}