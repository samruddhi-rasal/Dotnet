using System;

class Program
{
    static void Main()
    {
        // Implicit Conversion
        int x = 100;
        long y = x;

        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine("int x = " + x);
        Console.WriteLine("long y = " + y);

        // Explicit Conversion
        double d = 3.14;
        float f = (float)d;

        Console.WriteLine("\nExplicit Conversion:");
        Console.WriteLine("double d = " + d);
        Console.WriteLine("float f = " + f);
    }
}