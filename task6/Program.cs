//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.WriteLine("Введите размер массива: ");
int x = int.Parse(Console.ReadLine());
int[] myArray = new int[x];
Random rand = new Random();
int i = 0;

while (i < myArray.Length)
{
myArray[i] = rand.Next(123); 
Console.Write(myArray[i] + " ");
i++;
}

int count = 0;
i = 0;

while (i < myArray.Length)
{
    if (myArray[i]>=10 && myArray[i]<100)
    {
        count++;
        i++;
    }
    else 
    {
        i++;
    }
}
Console.WriteLine("Количество элементов == " + count);