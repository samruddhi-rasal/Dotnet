//Calculate the sum of all elements.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("Sum of all elements: " + sum);
    }
}