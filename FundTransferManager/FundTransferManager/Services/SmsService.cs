using FundTransfer.Models;
namespace FundTransferManager.Services;

public class SmsService : INotificationService
{
    public void send(string message)
    {
        Console.WriteLine("SMS :" + message);
    }
}