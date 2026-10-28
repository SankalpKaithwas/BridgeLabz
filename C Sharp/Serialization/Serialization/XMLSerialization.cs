using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class XMLSerialization
    {
        [Serializable]
        public class Serialize
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }


        public void Serialization()
        {
            var serialize = new Serialize();
            serialize.Id = 199;
            serialize.Name = "Kaithwas Sankalp";

            var xmlSerializer = new XmlSerializer(typeof(Serialize));
            using (StringWriter writer = new StringWriter())
            {
                xmlSerializer.Serialize(writer, serialize);
                string result = writer.ToString();
                Console.WriteLine(result);
                // Deserialization(result);
            }
        }

        public void Deserialization(string xmlString)
        {
            object serializer = "";
            var xmlSerializer = new XmlSerializer(typeof(Serialize));
            using (StringReader reader = new StringReader(xmlString))
            {
                serializer = xmlSerializer.Deserialize(reader);
            }
        }
    }
}