

Console.WriteLine("Enter a year:");
int year = int.Parse(Console.ReadLine());

// Using DateTime Function
if (DateTime.IsLeapYear(year))
{
    Console.WriteLine(year + " is a aleap year");
}
else
{
    Console.WriteLine("{0} Is not a leap year", year);
}


