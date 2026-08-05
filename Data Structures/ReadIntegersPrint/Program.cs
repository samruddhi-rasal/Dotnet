//Read 10 integers from the user and print them.

using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 integers:");

        // Read 10 integers
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Print the integers
        Console.WriteLine("\nThe entered numbers are:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}