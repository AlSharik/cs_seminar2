
int random = new Random().Next(10, 1000000);
System.Console.WriteLine(random);

while(random != 0)
{
    System.Console.WriteLine(random % 10);
    random /= 10;
}