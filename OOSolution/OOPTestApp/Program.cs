
namespace OOPsAppp;

using System.Reflection.Metadata.Ecma335;
using Banking;

public class Program
{
    public int  speed;
    public static int result;

    public static void Main(string [] args)
    {
        
        Account acct1=new Account();
        acct1.Balance=90000.00m;
        Console.WriteLine(acct1.Balance);

        Account acct2=new Account(50000);
        acct2.Balance=745000.00m;
        Console.WriteLine(acct2.Balance);

        SavingAccount svacct45= new SavingAccount();
        svacct45.Balance=98000.00m;
        Console.WriteLine(svacct45.Balance);

        result=67;
    }
}