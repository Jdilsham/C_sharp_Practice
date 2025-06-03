public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void Deposite(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New Balance: {Balance:C}");
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insuffient funds.");
        }
    }
}

public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    public SavingsAccount(string accountNumber, double interestRate, double balance) : base(accountNumber, interestRate)
    {
        InterestRate = interestRate;
    }

    public void ApplyInterest()
    {
        double interest = InterestRate / 100;
        Deposite(interest);
        Console.WriteLine($"Interest applied at {InterestRate}%. New Balance: {Balance:C}");
    }
}

public class progarm
{
    public static void main()
    {
        SavingsAccount mysaving = new SavingsAccount("12345", 1000, 2.5);
        mysaving.Deposite(500);
        mysaving.Withdraw(200);

        mysaving.ApplyInterest();
        Console.WriteLine($"Final Balance: {mysaving.Balance:C}");
        Console.ReadLine();
    }
}