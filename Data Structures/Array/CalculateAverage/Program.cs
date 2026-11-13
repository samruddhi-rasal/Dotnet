//Calculate the average.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 78 };

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Average: " + average);
    }
}