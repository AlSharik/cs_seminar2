System.Console.WriteLine("write number");
int number = Convert.ToInt32(Console.ReadLine());
int random = new Random().Next(10, 1000000);
bool kek = true;
while(kek)
{
    random = new Random().Next(10, 1000000);
    System.Console.WriteLine(random);
    if(random % number == 0)
    {
        System.Console.Write(" это кратное число");
        break;
    }
    
}