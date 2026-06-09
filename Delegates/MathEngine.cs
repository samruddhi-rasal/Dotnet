namespace pkg;

public class Mathengine
{
    public static double Add(double a, double b)
    {
        Console.WriteLine("Addition is " + (a+b));
        
        return a+b;
    }

    public static double Substract(double a, double b)
    {
       Console.WriteLine("Substraction is " + (a-b));
       return a-b;
    }

    public static double Multiply(double a, double b)
    {
        Console.WriteLine("Multiplication is " + (a*b));
        return a*b;
    }

    public static double Divide(double a, double b)
    {
       Console.WriteLine("Division is " + (a/b));
        return a/b;
    }
}





