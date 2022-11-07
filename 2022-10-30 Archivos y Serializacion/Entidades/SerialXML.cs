using System.Xml.Serialization;

namespace Entidades
{
    public class SerialXML<T> where T : class
    {
        public void Serializar(T item, string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, item);
            }
        }

        public T Deserializar(string path)
        {
            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                T item = xmlSerializer.Deserialize(streamReader) as T;
                return item;
            }
        }
    }
}