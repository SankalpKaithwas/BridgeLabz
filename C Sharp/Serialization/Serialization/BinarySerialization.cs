using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class BinarySerialization // in binary formate
    {
        [Serializable]
        public class Serialize
        {
            public string? ApplicantName { get; set; }
            public int ApplicantId { get; set; }
        }

        public void Serialization()
        {
            Serialize serialize = new Serialize();
            serialize.ApplicantId = 123;
            serialize.ApplicantName = "Sankalp Kaithwas";
            FileStream file = new FileStream(@"F:\BridgeLabz\C Sharp\Serialization\BinarySerialization.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter(); // serialize or desiarilize an object in binary format
            formatter.Serialize(file, serialize);
            Console.ReadKey();
            file.Close();
        }

        public void Deserialization()
        {
            string path = @"F:\BridgeLabz\C Sharp\Serialization\BinarySerialization.txt";
            FileStream file = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Serialize result = (Serialize)formatter.Deserialize(file);
            Console.WriteLine("Name - " + result.ApplicantName + " ID - " + result.ApplicantId);
            file.Close();
        }
    }
}
