using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    /*2.You need to create a secret bank account for the President of the nation.
     * The bank allows his/her account to be accessed by other family members.
     * The bank account should have a method which allows you to add a specified amount of money to the account.
     * Make sure that you make the method in such a manner that the method can be accessed by only the President
     * while keeping rest of the account visible to the family members. 
*/
    internal class SecretBankAccount
    {
        public string AccountHolder { get; private set; }
        public double Balance { get; private set; }
        private string PresidentPassword { get; set; }

        public SecretBankAccount(string accountHolder, string presidentPassword)
        {
            AccountHolder = accountHolder;
            Balance = 0;
            PresidentPassword = presidentPassword;
        }

        public void ViewAccountDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance:C}");
        }

        public void AddMoney(double amount, string password)
        {
            if (password == PresidentPassword)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Successfully added {amount} to the account. New Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Amount to be added must be greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Access denied! Only the President can add money.");
            }
        }
    
    }
}
