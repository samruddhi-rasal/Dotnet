using Banking;

class Program
{
    public static void Main(string[] args){
    
Account acc=new Account();
acc.Deposit(200);
acc.Withdraw(300);

SavingAccount savAcc=new SavingAccount();
savAcc.InterestRate=5;
savAcc.Deposit(500);
savAcc.ApplyInterest(); 
savAcc.Withdraw(700);
savAcc.processTransaction();
acc.processTransaction();
}
}