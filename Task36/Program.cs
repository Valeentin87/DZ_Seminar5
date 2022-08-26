// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = new int[4];
int[] randomArray = FillArray(array);
PrintArray(randomArray);
Console.WriteLine();
int result = SumOddPozition(randomArray);
Console.WriteLine($"сумма нечётных элементов массива равна {result}");
int SumOddPozition (int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}



int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next();
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

