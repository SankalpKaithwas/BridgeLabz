
Random random = new Random();
int coinCheck = random.Next(0, 2);
if (coinCheck == 1)
{
    Console.WriteLine("You got Head");
}else
{
    Console.WriteLine("You got Tail");
}
