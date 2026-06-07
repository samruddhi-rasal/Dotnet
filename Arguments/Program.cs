public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Parameter count = {0}", args.Length);
        Console.WriteLine("Hello {0} {1}", args[0], args[1]);
    }
}
