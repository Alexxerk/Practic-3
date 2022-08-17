//Нахождение суммы положительных и отрицательных элементов массива.

int[] myArray = new int[12];
Random rand = new Random();
int i = 0;  
int y = 0;       
while (i < myArray.Length)
{
    myArray[i] = rand.Next(-9, 11);
    if(myArray[i] < 0)
    {
        y = myArray[i] + y;
    }
    i++;
}

Console.Write("Сумма отрицательных элементов массива == "); 
Console.Write(y);
Console.WriteLine(" ");
y = 0;
i = 0;
while (i < myArray.Length)
{
    if(myArray[i] > 0)
    {
        y = myArray[i] + y;
    }
    i++;
}
Console.Write("Сумма положительных элементов массива == "); 
Console.Write(y);
Console.WriteLine(" ");
i = 0;
while (i < myArray.Length)
{
    Console.Write(myArray[i] + " ");
    i++;
}
Console.Write(" элементы массива");



