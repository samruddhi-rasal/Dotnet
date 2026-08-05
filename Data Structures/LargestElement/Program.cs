//Find the largest element.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 45, 20, 78, 30, 56 };

        int largest = numbers[0];

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }

        Console.WriteLine("Largest element: " + largest);
    }
}