// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int ArraySize()
{
    Console.WriteLine("Enter an array size: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void EvenNumbersCount(int[] ar)
{
    int count = 0;
    for (int index = 0; index < ar.Length; index++)
    {
        if (ar[index] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Quantity of even numbers = {count}");
}

void WriteArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

int[] array = GetArray(ArraySize(), 100, 1000);
Console.WriteLine();
WriteArray(array);
Console.WriteLine();
EvenNumbersCount(array);
