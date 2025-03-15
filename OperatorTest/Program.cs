using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Console.WriteLine("Enter First Number : ");
            //int a=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number : ");
            //int b=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Addition = {a+b}");
            //Console.WriteLine($"Substarction = {a-b}");
            //Console.WriteLine($"Multification = {a*b}");
            //Console.WriteLine($"Division = {a/b}");
            //Console.WriteLine($"Reminder = {a%b}");

            //relational operators
            //int x=10,y=20 ,z=30;

            //Console.WriteLine(x == y);
            //Console.WriteLine(y == z);
            //Console.WriteLine(z >= x);
            //Console.WriteLine(x != y);
            //Console.WriteLine(y != z);
            //Console.WriteLine(z <= x);

            //logical operators
            //Console.WriteLine(x<y && y==z);
            //Console.WriteLine(x>y ||  y==z);
            //Console.WriteLine(!(x>z) );

            //increament and decreament
            //int xy = 10;
            //Console.WriteLine(xy++);//10
            //Console.WriteLine(xy--);//11
            //Console.WriteLine(++xy);//11
            //Console.WriteLine(--xy);//10

            //swap two numbers without third variable 
            //int a = 10, b = 20;
            //Console.WriteLine("Before swapping");
            //Console.WriteLine(a + " " + b);
            //a = a + b; 
            //b = a - b; 
            //a = a - b;
            //Console.WriteLine("After Swapping");
            //Console.WriteLine(a +" "+ b);

            //ternary operator
            //int a = 10, b = 20, max,min;
            //max=a>b?a:b;
            //min=a<b?a:b;
            //Console.WriteLine($"max num is {max}");
            //Console.WriteLine($"min num is {min}");

            //using ternary num is positive or negetive
            //Console.WriteLine("Enter number");
            //int n=Convert.ToInt32(Console.ReadLine());
            //String result = n > 0 ? "positive" : (n < 0 ? "negetive" : "zero");
            //Console.WriteLine(result);

            //conditional statments
            //int age = 19;
            //if (age >= 18)
            //{
            //    Console.WriteLine("You can vote");
            //}
            //else {
            //    Console.WriteLine("You cant't Vote");
            //}


            //switch demo
            int opt = 2;
            switch (opt)
            {
                case 1:
                    {
                        Console.WriteLine("one");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("two");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("");
                        break;
                    }
            }


















        }
    }
}
