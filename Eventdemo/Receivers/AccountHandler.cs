namespace Banking;

public class AccountHandler{
    public void PayIncomeTax(object? sender, EventArgs e){
        Console.WriteLine("Paying income tax");
    }

    public void BlockAccount(object? sender, EventArgs e){
        Console.WriteLine("Blocking Account");
    }

   public void Notify(object? sender, EventArgs e){
        Console.WriteLine("Notifying Account");
    }

}