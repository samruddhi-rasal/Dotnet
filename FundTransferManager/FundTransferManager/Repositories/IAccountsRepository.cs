using FundTransfer.Models;
namespace FundTransferManager.Repositories
{
    public interface IAccountsRepository
    {
        List<Account> GetAllAccounts();

        bool SaveAllAccounts(List<Account> accounts);
    }
    }