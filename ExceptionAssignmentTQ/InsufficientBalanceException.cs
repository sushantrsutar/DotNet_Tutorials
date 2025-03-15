using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignmentTQ
{
    //3.WAP to create custom exception on InsufficientBalanceException 
    //for Account class while withdrawing money
    class InsufficientBalanceException:Exception 
    {
        public InsufficientBalanceException(string msg):base(msg) { }
    }

    class Account {
        public double balance = 5000;

        public void Withdraw(double amt) {
            if (amt > balance)
            {
                throw new InsufficientBalanceException("Insufficient Balance");
            }
            else {
                Console.WriteLine("withdraw successfull");
            }
        }
    }
}
