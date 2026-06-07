class Account{
    public decimal Balance { get; set;}



    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Amount deposited. New balance: {Balance}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Amount withdrawn. New balance: {Balance}");
        }
    }
        public virtual void processTransaction()
        {
            Console.WriteLine("Processing transaction in Account class");
        }
    }
