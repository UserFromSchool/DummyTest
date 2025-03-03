// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Goodbye world!");


static double GetAverage(int[] numbers)
{
    return Enumerable.Average(numbers);
}


int[] array = { 1, 2, 3, 4, 5 };
GetAverage(array);