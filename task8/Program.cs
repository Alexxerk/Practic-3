//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
Console.WriteLine("элементы массива.  ");

int z = x - 1;
int y = 0;
int repeat = x / 2;
int quantity = 1;
i = 0;

while (quantity <= repeat)
{
    y = myArray[z] * myArray[i];
    z = z - 1;
    i++;
    quantity++;
    Console.Write(y + " ");
}
Console.Write(" каждое число равняется произведению пар (1го числа и последнего числа и так далле смещаясь к центру массива.");