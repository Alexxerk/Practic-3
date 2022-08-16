//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
double[] myArray = new double[x];
Random rand = new Random();
Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());
int i = 0;

while (i < myArray.Length)
{
    myArray[i] = rand.Next(min, max) + rand.NextDouble();

    Console.Write(myArray[i] + " ");
    i++;
}
Console.WriteLine("элементы массива.  ");

i = 0;
double max1 = myArray[i];
i++;
while (i < myArray.Length)
{
    if (max1 > myArray[i])
    {
        i++;
    }
    else
    {
        max1 = myArray[i];
        i++;
    }
}
Console.WriteLine("Максимальное число массива = " + max1);

i = 0;
double min1 = myArray[i];
i++;
while (i < myArray.Length)
{
    if (min1 < myArray[i])
    {
        i++;
    }
    else
    {
        min1 = myArray[i];
        i++;
    }
}
Console.WriteLine("Минимальное число массива = " + min1);

double z = max1 - min1;
if (z < 0)
{
    z = -z;
}
Console.WriteLine("Разница между минимальным и максимальным значением массива == " + z);

