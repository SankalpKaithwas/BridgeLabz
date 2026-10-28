using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class JSONSerialization
    {

        [DataContract]
        public class Serialize
        {
            [DataMember]
            public string? Name { get; set; }
            [DataMember]
            public int Id { get; set; }
        }

        public void JSONSerialize()
        {
            Serialize jsonSerialize = new Serialize() { Id = 1123, Name = "Sankalp" };
            //jsonSerialize.Name = "kaithwas";
            string JsonData = JsonConvert.SerializeObject(jsonSerialize);
            Console.WriteLine(JsonData);
        }

        public void Deserialize()
        {
            string format = @"{'Id': 12, 'Name': 'Kaithwas Sankalp'}";
            Serialize data = JsonConvert.DeserializeObject<Serialize>(format);
            Console.WriteLine(data.Name);
            Console.WriteLine(data.Id);
        }
    }
}
