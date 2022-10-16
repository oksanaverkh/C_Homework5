// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ArraySize()
{
    Console.WriteLine("Enter an array size: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ArrayMinimum()
{
    Console.WriteLine("Enter an array minimum number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int ArrayMaximum()
{
    Console.WriteLine("Enter an array maximum number: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void GetOddIndexNumsSum(int[] ar)
{
    int index = 0;
    int oddIndexNumsSum = 0;
    while (index < ar.Length - 1)
    {
        if (index % 2 == 1)
        {
            oddIndexNumsSum = oddIndexNumsSum + ar[index];
        }
        index++;
    }
    Console.WriteLine($"Sum of numbers with odd-numbered indexes = {oddIndexNumsSum}");
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = GetArray(ArraySize(), ArrayMinimum(), ArrayMaximum());
Console.WriteLine();
WriteArray(array);
Console.WriteLine();
GetOddIndexNumsSum(array);
