
namespace Banking;
using Handlers;

public class Account
{
    public double Balance{get;set;}
    public  event  Sender  notify;
    public event TaxInspector overBalance;


    public void Withdraw(double amount)
    {
        double calculatedResult=this.Balance -amount;
        notify.Invoke("amount has been deducted from account");
    }

    public void Deposit(double amount)
    {
        double calculatedResult=this.Balance + amount;
        notify.Invoke("amount has been deposited to account");

        //Business Logic
        if(calculatedResult >= 250000)
        {
            overBalance.Invoke(calculatedResult);
        }
    
    }
}