namespace Rege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegEX regEX = new RegEX();
            regEX.Validate("sankalp");
            regEX.ValidateLastName("Sankalp Kaithwas");
        }
    }
}
