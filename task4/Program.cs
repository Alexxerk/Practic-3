// Определяем есть ли в массиве заданное число.
Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int[] myArray = new int[x];
Random rand = new Random();
int i = 0;


Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число которое будем искать: ");
int find = int.Parse(Console.ReadLine());

while (i < myArray.Length)
{
    myArray[i] = rand.Next(min, max);
    i++;
}

i = 0;

while (i < myArray.Length)
{
    if (myArray[i] == find)
    {
        Console.WriteLine("индекс искомого числа == " + i);
        break;
    }
    i++;
}


