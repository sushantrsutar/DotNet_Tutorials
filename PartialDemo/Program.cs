using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    partial class Calculator
    {
        public void add1(int a, int b)
        {
            Console.WriteLine("sum = " + (a + b));
        }
        public void findSqure1(int x)
        {
            Console.WriteLine("Squre = " + (x * x));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
