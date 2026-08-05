//Print only odd numbers.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 15, 20, 25, 30, 35, 40 };

        foreach (int num in numbers)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}