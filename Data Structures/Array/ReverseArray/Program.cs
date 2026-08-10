
//Reverse the Array
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

