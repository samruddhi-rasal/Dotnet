//Print nos greater than 50

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 55, 70, 45, 90, 30, 60, 25, 80, 50 };

        int count = 0;

        foreach (int num in numbers)
        {
            if (num > 50)
            {
                count++;
            }
        }

        Console.WriteLine("Numbers greater than 50: " + count);
    }
}