using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateDemoTQ.Calculation;

namespace DelegateDemoTQ
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            //singlecast delegation
            //Calculation calculation = new Calculation();
            //MyDelegation DelegationObj = new MyDelegation(calculation.Add);
            //DelegationObj(2, 5);
            //DelegationObj.Invoke(4, 6);

            //DelegationObj = calculation.Sub;
            //DelegationObj.Invoke(10,3);


            //multicast delegattion
            //Calculation c = new Calculation();
            //MyDelegation m = new MyDelegation(c.Add);
            //m += c.Sub;//for add delegation
            //m+= c.Mult;
            ////m-=c.Mult;//for remove delegetion
            ////m -= c.Add;

            //Delegate[] list=m.GetInvocationList();
            //foreach (Delegate d in list) { 
            //    d.DynamicInvoke(10,5);
            //}


            /*Create a class User, create a method with name AccpetName(string name),
             * convert the name in upper case & return.
               Create the delegate to hold AcceptName method reference & invoke using delegate*/
            //User user = new User();
            ////Console.WriteLine(user.AcceptName("abcd"));
            //Mydelegate d = new Mydelegate(user.AcceptName);
            //string n = d.Invoke("sushant");
            //Console.WriteLine(n);


            //annonymus method delegation
            //Mydelegate mydelegate = delegate (string s)
            //{
            //    return s.ToUpper();
            //};
            //Console.WriteLine(mydelegate("sushant"));


            //Event bindig
            //Student s1=new Student();
            //Massage m1= new Massage();

            //s1.pass += new Mydelegate1(m1.PassMsg);
            //s1.fail += new Mydelegate1(m1.FailMsg);

            //s1.AcceptMarks(20);
            //s1.AcceptMarks(44);



            /*Create a Bank a class, with Debit & Credit method
            You can assign a default balance using constructor
            Credit method will accept the amount that needs to be added in balance
            Debit method will accept the amount that needs to be deducted from the balance.
            If amount is greater than balance raise an event → insufficient balance
            If balance is low (< 3000) raise an event low balance
            If balance is zero then raise an event zero balance.
            Also use exception handling in the code*/

            Bank bank = new Bank(10000);
            BankMessage bankMessage = new BankMessage();
            bank.InsufficientBalance += bankMessage.InsufficientBalance;
            bank.LowBalance += bankMessage.LowBalance;
            bank.ZeroBalance += bankMessage.ZeroBalance;
            bank.InvalidAmt += bankMessage.InvalidAmount;

            bank.ShowBalance();
            try
            {
                bank.Debit(678);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            //bank.Credit(0345);
            //bank.Debit(0);
            //bank.Debit(10000);


        }
    }
}
