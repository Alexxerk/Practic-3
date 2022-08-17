// Массив из 8 элементов в котором значения от [0, 1]

int[] array = new int[8];
Random rand = new Random();
int index = 0;

while (index < 8)
{
    array[index] = rand.Next(2);
    Console.WriteLine(array[index]);
    index++;
}

