using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a Bank a class, with Debit & Credit method
You can assign a default balance using constructor
Credit method will accept the amount that needs to be added in balance
Debit method will accept the amount that needs to be deducted from the balance.
If amount is greater than balance raise an event → insufficient balance
If balance is low (< 3000) raise an event low balance
If balance is zero then raise an event zero balance.
Also use exception handling in the code*/
namespace DelegateDemoTQ
{
    public delegate void BankDelegate();

    internal class Bank
    {
        public event BankDelegate InsufficientBalance;
        public event BankDelegate LowBalance;
        public event BankDelegate ZeroBalance;
        public event BankDelegate InvalidAmt;

        public double Balance;

        public Bank(double Balance)
        {
            this.Balance = Balance;
        }
        public void ShowBalance() {
            Console.WriteLine($"Balance : {Balance}");
        }
        public void Credit(double Amt)
        {
            if (Amt > 0)
            {
                Balance += Amt;
                Console.WriteLine($"{Amt} credited successfully.");
                Console.WriteLine($"Updated balance: {Balance}");
            }
            else
            {
                InvalidAmt();
            }
        }

        public void Debit(double Amt)
        {
            if (Amt <= 0) {
                InvalidAmt();
            }
            else if (Amt > Balance)
            {
                InsufficientBalance();
            }
            else
            {
                Balance -= Amt;
                Console.WriteLine($"{Amt} debited Successfully.");
                Console.WriteLine($"Updated balance: {Balance}");

                if (Balance == 0)
                {
                    ZeroBalance();
                }
                else if (Balance < 3000)
                {
                    LowBalance();
                }
            }
        }
    }

    class BankMessage
    {
        public void InsufficientBalance()
        {
            Console.WriteLine("Error: Insufficient Balance In Account!");
        }

        public void LowBalance()
        {
            Console.WriteLine("Warning: Your balance is low!");
        }

        public void ZeroBalance()
        {
            Console.WriteLine("Alert: Your balance is zero!");
        }

        public void InvalidAmount()
        {
            Console.WriteLine("Error: Invalid amount entered!");
        }
    }
}

    

