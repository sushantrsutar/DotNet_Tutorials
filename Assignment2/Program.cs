using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    //1. Find if the given number is prime or not.
            //     bool isPrime(int num) {
            //        if (num < 2)
            //        {
            //            return false;
            //        }
            //        else {
            //            for (int i = 2; i <= Math.Sqrt(num); i++) {
            //                if (num % i == 0) { 
            //                    return false;
            //                }
            //            }
            //        }
            //        return true;
            //    }

            //    Console.Write("Enter the Number :");
            //    int n=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(isPrime(n)?$"{n} is Prime Number ":$"{n} is Not Prime Number");

            //-------------------------------------------------------------------------------

            ////2. Check if the given number is Armstrong or not.
            //bool isArmstrong(int num)
            //{
            //    int original = num;
            //    int sum = 0;
            //    int digits = num.ToString().Length;
            //    for (int i = num; i > 0; i /= 10)
            //    {
            //        int digit = i % 10; // Extract last digit
            //        sum += (int)Math.Pow(digit, digits); // Add digit^digits to sum
            //    }
            //    return sum == original;
            //}
            //    Console.Write("Enter the number : ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(isArmstrong(n) ? $"{n} is Armstrong Number " : $"{n} is Not Armstrong Number");

            //----------------------------------------------------------------------------------

            ////3. Find out given number is palindrome or not   -> 121
            //bool isPalindrom(int num)
            //{
            //    int original = num;
            //    int reverse = 0;
            //    while (num > 0)
            //    {
            //        int digit = num % 10;
            //        reverse = reverse * 10 + digit;
            //        num /= 10;
            //    }
            //    return reverse == original;
            //}

            //Console.WriteLine("Enter number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(isPalindrom(n)?"Palindrom" : "Not a Palindrom");

            //-------------------------------------------------------------------------------

            ////4. Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by user
            //Console.WriteLine("Enter The NUmber : ");
            //int n=Convert.ToInt32(Console.ReadLine());
            //genrateFibonacci(n);

            //void genrateFibonacci(int num) {
            //    int a = 0, b = 1;
            //    for (int i = 1; b < n; i++) {
            //        Console.Write(b+",");
            //        int temp = b;
            //        b = a + b;
            //        a=temp;
            //    }
            //    Console.WriteLine();
            //}

            //-----------------------------------------------------------------------------------------

            ////5. Find the sum of all digits of a number.  → 123 ⇒ 1+2+3 → 6

            //Console.WriteLine("Enter Number : ");
            //int n=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum of Digits = " + sumOfDigit(n));

            //int sumOfDigit(int num) {
            //    int sum = 0;
            //    while (num > 0) {
            //        int digit = num % 10;
            //        sum = sum + digit;
            //        num = num / 10;
            //    }

            //    return sum;

            //}

            //--------------------------------------------------------------------------------------


            ////6. Accept the number from user & print it in reverse order  – > 123  o/p -> 321


            //    Console.Write("Enter The Number: ");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Reversed Number: " + revNumber(n)); 


            // int revNumber(int num)
            //{
            //    int rev = 0;
            //    while (num > 0)
            //    {
            //        int digit = num % 10; // Extract the last digit
            //        rev = rev * 10 + digit; // Append the digit to the reversed number
            //        num /= 10; // Remove the last digit
            //    }
            //    return rev;
            //}

            //----------------------------------------------------------------------------

            //7. Find the factorial of a given number.
            Console.WriteLine("Enter Number : ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Factorial of {num} : "+findFact(num));

            int findFact(int n) {
                int fact = 1;
                for (int i = 1; i <= n; i++) { 
                fact=fact*i;
                }
                return fact;
            }














        }
    }
}
