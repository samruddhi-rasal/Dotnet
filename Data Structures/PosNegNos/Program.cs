//Count positive and negative numbers.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, -5, 20, -15, 0, 30, -25 };

        int positiveCount = 0;
        int negativeCount = 0;

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Positive numbers: " + positiveCount);
        Console.WriteLine("Negative numbers: " + negativeCount);
    }
}