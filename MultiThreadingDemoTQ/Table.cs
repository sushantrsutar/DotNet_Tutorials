using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemoTQ
{
   public class Table
    {
        public static void displayTable() {
            int n = 2;
            Console.WriteLine(Thread.CurrentThread.Name+" started ");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{i}*{n}={i*n}");
                Thread.Sleep(100);
            }
            Console.WriteLine(Thread.CurrentThread.Name+" Complet task ");
        }
    }
}
