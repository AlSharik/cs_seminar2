System.Console.WriteLine("Write number");
int num = new Random().Next(10, 100);

System.Console.WriteLine(num);

if(num % 10 > num / 10) System.Console.WriteLine(num % 10);
if(num % 10 < num / 10) System.Console.WriteLine(num / 10);
if(num % 10 == num / 10) System.Console.WriteLine($"equals {num / 10}");