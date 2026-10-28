
Console.WriteLine("Hello, World!");

string? input = Console.ReadLine();

string[] array = input!.Split(' ');

int[] num = Array.ConvertAll(array,int.Parse);

int price = 0;
for (int i = 0; i < num.Length - 1; i++)
{
    if (num[i] / 10000 == 1)
    {
        price = num[i + 1] * 50;
    }
    else if (num[i] / 10000 == 2)
    {
        price = (num[i + 1] * 100);
    }
}

if (price > 5000)
{
    price -= (price * 10 / 100);
    Console.WriteLine(price);
}
else
{
    Console.WriteLine(price);
}
