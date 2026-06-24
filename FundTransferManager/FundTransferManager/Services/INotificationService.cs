using FundTransfer.Models;
namespace FundTransferManager.Services;

public interface INotificationService
{
    void send(string message);
}