using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class Program
    {
        static void print() {
            Console.WriteLine("this is print method");
        }

        static void sum(int a, int b) {
            Console.WriteLine("sum : "+(a+b));
        }

        static int sub(int a, int b) {
            return a - b;
        }

        static void mult(int a, int b) {
            Console.WriteLine(a*b);
        }

        static int findFact(int n) {
            int fact = 1;
            for (int i = 1; i <= n; i++) {
                fact = fact * i;
            }
            return fact;    
        }

        static void displayFact() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"factorial of {i} : {findFact(i)}");
            }
        }

        //reverse number 
        static int reverseNumber(int num) {
            int reverse = 0;
            while (num != 0) { 
            int digit=num % 10;
            reverse=reverse*10+digit;
                num = num / 10;
            }
            return reverse;
        }

        //reverse number from given range
        static void displayRevNum(int a, int b) {
            for (int i = a; i <= b; i++) {
                Console.WriteLine($"{i} : {reverseNumber(i)}");
            }
        }

        //find palindrome number  
        static void palindromNumber(int n) {
            if (n == reverseNumber(n))
            {
                Console.WriteLine($"{n} is palindrom number");
            }
            else {
                Console.WriteLine($"{n} is not palindrom nunber");
            }
        }
        static bool isArmstrong(int num)
        {
            int original = num;
            int sum = 0;
            int digits=num.ToString().Length;

            while (num > 0) {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }
            return original == sum;
         }

        static void printArmstrongNumber(int a, int b) {
            for (int i = a; i <= b; i++) {
                if (isArmstrong(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        //optional parameter
        //take optional value for only last parameter or take for all
        static int sum2(int a  ,int b, int c = 1)
        {
            return (a + b + c);
        }

        static int sum1(int a=1, int b=1, int c = 1) {
            return (a + b + c);
        }

        static void Main(string[] args)
        {
            //Program.print();
            //print();
            //sum(1, 2);
            //int ans = sub(5,3);
            //Console.WriteLine("sub : "+ans);
            //mult(3, 3);

            //int fact = findFact(5);
            //Console.WriteLine(fact);

            //displayFact();

            //Console.WriteLine(reverseNumber(123));
            //displayRevNum(10, 20);
            //palindromNumber(122);

            //Console.WriteLine(isArmstrong(153));
            //printArmstrongNumber(100,900);

            //Console.WriteLine(sum1(3,2,1));
            //Console.WriteLine(sum1());

            //Console.WriteLine(sum2(3,4));










        }
    }
}
