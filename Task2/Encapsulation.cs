using System;
class BankAccount
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid deposit amount.");
            return;
        }

        balance += amount;
        Console.WriteLine("Deposit success.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine("Withdrawal success.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.Deposit(1000);
        Console.WriteLine("Balance:" + account.Balance);

        account.Withdraw(300);
        Console.WriteLine("Balance: " + account.Balance);

        account.Deposit(-100);
        account.Withdraw(1000);
        account.Withdraw(0);

        Console.WriteLine("Final Balance: " + account.Balance);
    }
}
