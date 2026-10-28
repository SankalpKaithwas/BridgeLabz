
using Serialization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose 1: Binary");
        //Console.WriteLine("Binary serialization");
        //BinarySerialization binarySerialization = new BinarySerialization();
        ////  binarySerialization.Serialization();
        //binarySerialization.Deserialization(); // attempt to desirialize an empty stream

        //JSONSerialization jSONSerialization = new JSONSerialization();
        //jSONSerialization.JSONSerialize();
        //jSONSerialization.Deserialize();

        XMLSerialization xMLSerialization = new XMLSerialization();
        xMLSerialization.Serialization();
        



    }
}