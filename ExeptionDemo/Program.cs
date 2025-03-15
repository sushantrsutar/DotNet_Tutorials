using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try{
                Console.WriteLine("Enter first number : ");
                int a=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number : ");
                int b=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"result : {a / b}");
            }
            catch(Exception e) {
                Console.WriteLine(e);
            }
        }
    }
}
