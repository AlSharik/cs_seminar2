
int random = new Random().Next(10, 1000000);
System.Console.WriteLine(random);

int random1 = random;
int index = 0;
// определяем длину числа
while(random1 != 0)
{
    index++;
    random1 /= 10;
}
random1 = random;
int[] array = new int[index];
index = 0;
// c конца заполнили массив цифр
while(random1 != 0)
{
    System.Console.WriteLine(random1 % 10);
    array[index] = random1 % 10;
    index++;
    random1 /= 10;
}
// сортируем массив
int s = 0;
for(int m = array.Length; m > 0; m--)
{
    for(int n = 0; n < m-1; n++)
    {
        if( array[n] > array[n+1])
        {
            s = array[n+1];
            array[n+1] = array[n];
            array[n] = s;
        }
    }      
}

for(int n = 0; n < array.Length; n++)
{
    System.Console.WriteLine(array[n]);
}      