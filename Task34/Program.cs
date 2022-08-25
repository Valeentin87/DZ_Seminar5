// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Hello, World!");
int[] array = new int[4];
int[] FillArray(int[] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100,1000);
    }
    return arr;
}
int[] result = FillArray(array);
PrintArray(result);
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
       Console.WriteLine($"{arr[i]} "); 
    }
}
