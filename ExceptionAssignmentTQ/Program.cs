using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExceptionAssignmentTQ
{
   
    //1.Wap to create show the usage of throw keyowrd , Create a class and
    // if the age is less than 18 throw an exception
    class AgeCheck {
        public void ValidAge(int age) {
            if (age < 18)
            {
                throw new ArithmeticException("Age less than 18");
            }
            else {
                Console.WriteLine("Valide Age");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Wap to create show the usage of throw keyowrd , Create a class and
            // if the age is less than 18 throw an exception
            //AgeCheck ageCheck = new AgeCheck();
            //try
            //{
            //    ageCheck.ValidAge(20);
            //}
            //catch (ArithmeticException e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //2.WAP to create a custom exception on invalid password
            //ValidePassword validePassword = new ValidePassword();
            //try
            //{
            //    validePassword.checkPassword("fsyfskjsda");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}


            //3.WAP to create custom exception on InsufficientBalanceException 
            //for Account class while withdrawing money
            //Account account = new Account();
            //try
            //{
            //    account.Withdraw(70000);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}


            //4.Create a class User with parametric constructor to accept a user name.
            //Create User defined Exception class as NameException.In user class check condition as,
            //If user name is null or empty in the parameter of constructor, raise an exception &
            //display error message as “Name is required”.
            try
            {
                Name name = new Name("sushant");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //5.Use the same above user class. Add method AcceptAge to read age from parameter.
            //Create one user defined exception class AgeException.
            //If user has age less than 18 then display message as “driving license can not be issued”
            //else display message as “driving license will be issued”
            User user = new User();
            //try
            //{
            //    user.AcceptAge(17);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
