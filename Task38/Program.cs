// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] array = new double[4];
double[] randomArray = FillArray(array);
double result = DifferenceMaxMinInArray(randomArray);
PrintArray(randomArray);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");
double DifferenceMaxMinInArray(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double difference = max - min;
    return difference;
}


double[] FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next();
    }
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

