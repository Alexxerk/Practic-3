//Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.WriteLine("Введите размер массива: ");
int z = int.Parse(Console.ReadLine());
int[] array = new int[z];
Console.WriteLine("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());
int i = 0;
Random rand = new Random();
int y = 0;

while (i < z)
{
    array[i] = rand.Next(min, max);
    Console.Write(array[i] + " ");
    i++;
}

i = 1;

while (i < z)
{
y = y + array[i];
i = i + 2;
}

Console.WriteLine("Сумма элементов стоящих на нечетной позиции == " + y);


