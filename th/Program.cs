
int random = new Random().Next(10, 1000000);
System.Console.WriteLine(random);

int random1 = random;
int index = 0;
while(random1 != 0)
{
    index++;
    random1 /= 10;
}
random1 = random;
int[] array = new int[index];
index = 0;
// c конца
while(random1 != 0)
{
    System.Console.WriteLine(random1 % 10);
    array[index] = random1 % 10;
    index++;
    random1 /= 10;
}

System.Console.WriteLine("В другую сторону");

random1 = random;
while(index - 1 >= 0)
{
    System.Console.WriteLine(array[index-1]);
    index--;
}