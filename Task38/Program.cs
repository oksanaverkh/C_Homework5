// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int ArraySize()
{
    Console.WriteLine("Enter an array size: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

double ArrayMinimum()
{
    Console.WriteLine("Enter an array minimum number: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

double ArrayMaximum()
{
    Console.WriteLine("Enter an array maximum number: ");
    double number = double.Parse(Console.ReadLine());
    return number;
}

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble()*(maxValue - minValue);
    }
    return result;
}

void FindMinAndMaxNumbersDiff(double[] ar)
{
    int index = 0;
    double min = ar[index];
    double max = ar[index];
    while (index < ar.Length)
    {
        if (ar[index] > max)
        {
            max = ar[index];
        }
        else
        {
            if (ar[index] < min)
            {
                min = ar[index];
            }
        }
        index++;
    }
    double diff = max - min;
    Console.WriteLine($"Minimum number = {Math.Round(min,2)}");
    Console.WriteLine($"Maximum number = {Math.Round(max,2)}");
    Console.WriteLine($"Difference between maximum and minimum numbers = {Math.Round(diff,2)}");
}

void WriteArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{Math.Round(arr[i],2)}  ");
    }
    Console.Write($"{Math.Round(arr[arr.Length-1],2)}]");
}

double[] array = GetArray(ArraySize(), ArrayMinimum(), ArrayMaximum());
Console.WriteLine();
WriteArray(array);
Console.WriteLine();
FindMinAndMaxNumbersDiff(array);