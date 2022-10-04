int Maxnum(int number)
{
    int max = 0;

    if(number % 10 > number / 10) max = number % 10;
    if(number % 10 < number / 10) max = number / 10;
    return max;
}
int num = new Random().Next(10, 10000);

System.Console.WriteLine(num);

int first = Maxnum(num / 100);
int second = Maxnum(num % 100);

if(first >= second) System.Console.WriteLine(first);
if(first < second) System.Console.WriteLine(second);