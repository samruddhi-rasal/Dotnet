using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        int count = 0;

        foreach (char ch in str)
        {
            count++;
        }

        Console.WriteLine("Length of the string = " + count);
    }
}