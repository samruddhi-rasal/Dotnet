using pkg;

class program
{
    public delegate double MathOperation(double a, double b);
    public static void Main(string [] args)
    {
        
        MathOperation Addition= new MathOperation(Mathengine.Add);
        MathOperation Substract= new MathOperation(Mathengine.Substract);
        MathOperation Multiply= new MathOperation(Mathengine.Multiply);
        MathOperation Divide= new MathOperation(Mathengine.Divide);

        
    while(true){

         int choice;
        Console.WriteLine("Enter your choice: 1.Addition 2.Substraction 3.Multiplication 4.Division 5.Exit");
        choice = Convert.ToInt32(Console.ReadLine());

    switch (choice) {
    case 1:
        {
             // code to execute
        Console.WriteLine("Enter two numbers: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());

          Addition(a,b);
                    }
        
        break;
        
    case 2:
    {
    Console.WriteLine("Enter two numbers: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
          Substract(a,b);
    }
        // code to execute
        break;

    case 3:
      {Console.WriteLine("Enter two numbers: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Multiply(a,b);}
            break;

    case 4:
     {Console.WriteLine("Enter two numbers: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Divide(a,b);}
    break;

    case 5:
      Environment.Exit(0);
      break;

    default:
        // code to execute if no match
        break;
}   
        

      

      
    
    }}}