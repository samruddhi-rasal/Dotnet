namespace Banking;

class SavingAccount : Account
{
    public decimal InterestRate{ get; set;}   =0.5m;

    public void ApplyInterest()
    {
         Balance = Balance * InterestRate / 100;
      
        Console.WriteLine($"Interest applied at rate {InterestRate}%. New balance: {Balance}");
    }
    public override void processTransaction()
    {
        Console.WriteLine("Processing transaction in SavingAccount class");
    }

}
