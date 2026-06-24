namespace FundTransfer.Models
{
    public class Account
    {
        public string Name { get; set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}