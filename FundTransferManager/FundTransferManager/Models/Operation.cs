namespace FundTransfer.Models;

public class Operation
{
    
    public string AccountNumber { get; set; }

    public string Status { get; set; }

    public string StatusMessage { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedAt{ get; set; }

    public decimal CurrentBalance { get; set; }
}