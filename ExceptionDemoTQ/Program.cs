using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemoTQ
{
    internal class Program
    {
        public static void checkage(int age) {
            if (age < 25 || age > 45) {
                throw new ArithmeticException("Age is not valide");
            }
        }
        static void Main(string[] args)
        {
            //    int a = 10;
            //    int b = 0;
            //    int div;
            //    int[] arr = { 2, 3, 4 };

            //try
            //{
            //    div = a / b;
            //    Console.WriteLine(arr[5]);
            //    Console.WriteLine("div:" + div);
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e);
            //}
            //catch (IndexOutOfRangeException e) {
            //    Console.WriteLine(e);
            //}



            //nested try
            //try {
            //    //div = a/b; its jump on main catch block
            //    try
            //    {
            //        div = a / b;
            //    }
            //    catch (Exception ex) {
            //        Console.WriteLine(ex);
            //    }

            //}
            //catch(Exception e) { Console.WriteLine("main catch block"); }



            

            //try
            //{
            //    checkage(12);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //Application exception

            //Book book = new Book();
            //try
            //{
            //    book.findBook(12);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            Vehical vehical = new Vehical();
            try
            {
                vehical.speed(140);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }







        }
    }
}
