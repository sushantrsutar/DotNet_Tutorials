using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutDemo
{
    internal class Program
    {
        //ref demo
        //public static void swap(ref int a,ref int b) {
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //}

        //out demo
        //public static void swap(out int a, out int b)
        //{
        //     a = 25;
        //     b = 30;
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //}

        ////out with multiple return values
        static void calc(int a, int b,out int sum,out int sub,out int mult) {
            sum = a + b;
            sub = a - b;
            mult = a * b;
        }
        static void Main(string[] args)
        {
            //ref demo
            //int x = 10;
            //int y = 20;
            //swap(ref x,ref y);
            //Console.WriteLine("x= "+x);
            //Console.WriteLine("y= "+y);

            //out demo
            //int x;
            //int y;
            //swap(out x, out y);
            //Console.WriteLine("x= " + x);
            //Console.WriteLine("y= " + y);
           
            //out with multiple return values
            int x = 30;
            int y = 20;
            
            int sum = 0;
            int sub = 0;
            int mult = 0;
            calc(x, y,out sum,out sub,out mult);
            Console.WriteLine("sum : "+sum);
            Console.WriteLine("sub : "+sub);
            Console.WriteLine("mult : "+mult);

        }
    }
}
