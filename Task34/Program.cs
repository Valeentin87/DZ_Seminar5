// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Hello, World!");
int[] array = new int[4];
int[]
PrintArray(array);
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
       Console.WriteLine($"{arr[i]} "); 
    }
}
