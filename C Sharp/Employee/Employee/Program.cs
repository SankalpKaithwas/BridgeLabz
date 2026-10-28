
// UC1 Employee Attendence
int isPresent = 1;  //constant
Random random = new Random();
int employeeStatus = random.Next(0, 2);
if (employeeStatus == isPresent)
{
    Console.WriteLine("Employee is Present");
}
else
{
    Console.WriteLine("Employee is Absent");
}
