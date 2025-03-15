using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*"1.Write a C# program to create a base class Shape with a method called CalculateArea(). 
             * Create three subclasses: Circle, Rectangle, and Triangle. 
             * Override the CalculateArea() method in each subclass to calculate and return the shape's area.
*/
            //Shape circle = new Circle(3);
            //Shape tringle = new Triangle(21,30);
            //Shape rectangle = new Rectangle(3, 5);
            //Console.WriteLine($"Area of circle = {circle.CalculateArea()}");
            //Console.WriteLine($"Area of tringle = {tringle.CalculateArea()}");
            //Console.WriteLine($"Area of rectangle = {rectangle.CalculateArea()}");

            /*4. Create a class Payment having a static method payBill
                If you pay the bill by cash you are not eligible for any discount  , method PayBill(double amt)
                If you pay by a  mode you get 15% discount on the bill  , method  PayBill(double amt, String mode)"
             */
            //Payment.payBill(120);
            //Payment.payBill(120, "mode");



            /*"1.Create a class Game having the method rules() and noOfPlayers(). 
                 Create a class BasketBall, Soccer, Cricket
                 which are child class of Game. Override the above methods and use method overriding
                 to show thw rules and noofPlayers according to the object passed
             */

            //Game game;
            //Console.WriteLine("BasketBall");
            //game = new BasketBall();
            //game.Rules();
            //game.noOfPlayers();

            //Console.WriteLine("Cricket");
            //game = new Cricket();
            //game.Rules();   
            //game.noOfPlayers();


            /*2. Write a C# program to create a class known as Person with methods called GetFirstName() and GetLastName().
            Create a subclass called Employee that adds a new method named GetEmployeeId() and overrides the GetLastName()
            method to include the employee's job title.*/

            //Person person = new Person("Amit", "Shah");
            //Console.WriteLine("Person Details:");
            //Console.WriteLine($"First Name: {person.GetFirstName()}");
            //Console.WriteLine($"Last Name: {person.GetLastName()}");
            //Console.WriteLine();
            //Employee employee = new Employee("Neeraj", "Patel", "Software Engineer", 12345);
            //Console.WriteLine("Employee Details:");
            //Console.WriteLine($"First Name: {employee.GetFirstName()}");
            //Console.WriteLine($"Last Name: {employee.GetLastName()}");
            //Console.WriteLine(employee.GetEmployeeId());

            /*"1.Write a C# program to create an abstract class BankAccount with abstract methods Deposit() and Withdraw().
             Create subclasses: SavingsAccount and CurrentAccount that extend the BankAccount class 
             and extends the respective methods to handle deposits and withdrawals for each account type.
             */
            //Console.WriteLine("Savings Account Operations:");
            //SavingsAccount savings = new SavingsAccount("Neha", 1000);
            //savings.DisplayBalance();
            //savings.Deposit(500);
            //savings.Withdraw(800); 
            //savings.Withdraw(300);
            //savings.DisplayBalance();

            //Console.WriteLine();

            //// CurrentAccount object
            //Console.WriteLine("Current Account Operations:");
            //CurrentAccount current = new CurrentAccount("Amar", 200);
            //current.DisplayBalance();
            //current.Deposit(800);
            //current.Withdraw(500);
            //current.Withdraw(600); 
            //current.Withdraw(1200); 
            //current.DisplayBalance();


      /*2.Write a C# program to create an abstract class Shape with abstract methods CalculateArea()
      and CalculatePerimeter(). 
     Create subclasses Circle and Triangle that extend the Shape class and implement the respective methods 
     to calculate the area and perimeter of each shape.*/




        }
    }
}
