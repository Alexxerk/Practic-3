//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int[] myArray = new int[x];
Random rand = new Random();
Console.WriteLine("Введите минимальное трехзначное число: ");
int min = int.Parse(Console.ReadLine());
int i = 0;
int chet = 0;
int unchet = 0;

Console.WriteLine("Введите максимальное трехзначное число: ");
int max = int.Parse(Console.ReadLine());

    while (i < myArray.Length);
    {
        myArray[i] = rand.Next(min, max);
        i++;
    }

    i = -1;

    while (i < myArray.Length);
    {
        i++;
        if (myArray[i] % 2 == 0)
        {
            chet++;
            
        }
        else 
        {
            unchet++;
            
        }
        
    }
    Console.WriteLine("Вывожу количество четных чисел == " + chet + " и не четных чисел == " + unchet);

