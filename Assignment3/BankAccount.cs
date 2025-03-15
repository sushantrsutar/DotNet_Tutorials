using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    /*"1.Write a C# program to create an abstract class BankAccount with abstract methods Deposit() and Withdraw().
    Create subclasses: SavingsAccount and CurrentAccount that extend the BankAccount class 
    and extends the respective methods to handle deposits and withdrawals for each account type.
    */
    public abstract class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; protected set; }
        public BankAccount(string accountHolder, double initialBalance)
        {
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public void DisplayBalance()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }

    public class SavingsAccount : BankAccount
    {
        private const double MinimumBalance = 500;
        public SavingsAccount(string accountHolder, double initialBalance): base(accountHolder, initialBalance)
        {

        }
        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully into Savings Account.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && (Balance - amount) >= MinimumBalance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully from Savings Account.");
            }
            else
            {
                Console.WriteLine($"Withdrawal denied! Minimum balance of {MinimumBalance} must be maintained.");
            }
        }

    }
    public class CurrentAccount : BankAccount
    {
        private const double OverdraftLimit = 1000; 

        public CurrentAccount(string accountHolder, double initialBalance)
            : base(accountHolder, initialBalance)
        {
        }

        public override void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully into Current Account.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0 && (Balance - amount) >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully from Current Account.");
            }
            else
            {
                Console.WriteLine($"Withdrawal denied! Overdraft limit of {OverdraftLimit} exceeded.");
            }
        }
    }
}
