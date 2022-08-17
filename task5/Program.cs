//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int[] myArray = new int[x];
Random rand = new Random();
Console.WriteLine("Введите минимальное трехзначное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное трехзначное число: ");
int max = int.Parse(Console.ReadLine());
int y = min;
int a = max;
int count = 0;

while (y != 0) 
{
    y = y / 10;
    count++;
}
if (count != 3)
{
    Console.WriteLine("Вы веели некоректное число");
    return;
}
else if (count == 3)
{
    count = 0;
    while (a != 0) 
    {
        a = a / 10;
        count++;
    }
    if (count != 3)
    {
        Console.WriteLine("Вы веели некоректное(ые) число(ла)");
        return;
    }
}



int i = 0;
int chet = 0;
int unchet = 0;

while (i < myArray.Length)
{
    myArray[i] = rand.Next(min, max);
    Console.Write(myArray[i] + " ");
    i++;
}

i = 0;

while (i < myArray.Length)
{
    if (myArray[i] % 2 == 0)
    {
        chet++;
        i++;
    }
    else
    {
        unchet++;
        i++;
    }
}
Console.WriteLine("Четные элементы массива == " + chet + ", нечетные элементы == " + unchet);





