//Замена на противоположние значения.

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int[] myArray = new int[x];
Random rand = new Random();
int i = 0;

Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

while (i < myArray.Length)
{
    myArray[i] = rand.Next(min, max);
    Console.Write(myArray[i] + " ");
    i++;
}

i = 0;

while (i < myArray.Length)
{
    myArray[i] = -myArray[i];
    i++;
}

Console.WriteLine("Вывод противоположных значений: ");
i = 0;

while (i < myArray.Length)
{
    Console.Write(myArray[i] + " ");
    i++;
}
 
