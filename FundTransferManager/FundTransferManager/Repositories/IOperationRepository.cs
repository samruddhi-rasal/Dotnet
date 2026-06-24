using FundTransfer.Models;
namespace FundTransferManager.Repositories
{
    public interface IOperationRepository
    {
        List<Operation> GetAllOperations();

        bool SaveAllOperations(List<Operation> operations);
    }
    }