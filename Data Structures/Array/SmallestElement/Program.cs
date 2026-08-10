//Find the smallest element.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 45, 20, 78, 30, 56 };

        int smallest = numbers[0];

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }

        Console.WriteLine("Smallest element: " + smallest);
    }
}