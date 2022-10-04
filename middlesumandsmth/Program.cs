System.Console.WriteLine("Write numbers");
double[] array = new double[5];
int counter = 0;


while(counter < array.Length)
{
    array[counter] = Convert.ToInt32(Console.ReadLine());
    counter++;
}

counter = 0;
double sum = 0;
//не знаю почему я написал не через фор, приходиться оновлять каунтер(индекс)
while(counter < array.Length)
{
    sum+=array[counter];
    counter++;
}
System.Console.WriteLine(sum);
System.Console.WriteLine(sum / array.Length);
