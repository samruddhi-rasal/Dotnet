using FundTransfer.Models;
namespace FundTransferManager.Handlers;

public class AccountsHandler : IAccountHandler
{
    public void OnUnderBalance(Account account)
    {
        Console.WriteLine("Amount is less than minimum balance policy");
    }

    public void OnOverBalance(Account account)
    {
        Console.WriteLine("Amount is more than maximum balance policy");
    }
}