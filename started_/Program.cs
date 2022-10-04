System.Console.WriteLine("Write number");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    System.Console.WriteLine(number%10);    
}
else
{
    System.Console.WriteLine("Less than 100");
}