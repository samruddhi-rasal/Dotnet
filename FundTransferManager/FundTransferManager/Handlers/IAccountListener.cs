using FundTransfer.Models;
namespace FundTransferManager.Handlers;

public interface IAccountHandler
{
    void OnUnderBalance(Account account);

    void OnOverBalance(Account account);
}