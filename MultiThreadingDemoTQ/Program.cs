using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemoTQ
{
    internal class Program
    {   public void Method1() {
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("Method 1 " + i+Thread.CurrentThread.Name);
            }
        }

        public void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Connecting to db");
                    Thread.Sleep(5000);
                    Console.WriteLine("Method 2 " + i + Thread.CurrentThread.Name);
                }
            }
        }

        
        public void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 " + i + Thread.CurrentThread.Name);
            }
        }

        //use of lock
        public void Display()
        {
            lock (this)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " started");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("i = "+ i);
                    Thread.Sleep(1000);
                }
                Console.WriteLine(Thread.CurrentThread.Name + " ended");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello ");
            //Thread t=Thread.CurrentThread;
            //t.Name = "main";
            //Console.WriteLine("current thread "+t.Name);

            //Program program = new Program();
            //Console.WriteLine("main thread started");
            //Thread t1 = new Thread(program.Method1)
            //{
            //    Name = "Thread 1"
            //};

            //Thread t2 = new Thread(program.Method2)
            //{
            //    Name = "Thread 2"
            //};
            //t2.Start();
            //t1.Start();

            //Thread t1 = new Thread(Table.displayTable)
            //{
            //    Name = "Thread-1"
            //};
            //Thread t2 = new Thread(Table.displayTable)
            //{
            //    Name = "Thread-2"
            //};
            //Thread t3 = new Thread(Table.displayTable)
            //{
            //    Name = "Thread-3"
            //};

            //t1.Start();
            //t1.Join();
            //t2.Start();
            //t2.Join();
            //t3.Start();


            //use of lock
            //Program program = new Program();
            //Thread t1 = new Thread(program.Display) { 
            //    Name="Thread 1"
            //};

            //Thread t2 = new Thread(program.Display)
            //{
            //    Name = "Thread 2"
            //};
            //Thread t3 = new Thread(program.Display)
            //{
            //    Name = "Thread 3"
            //};

            
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //ticketing booking using lock
            TicketingBook ticketingBook = new TicketingBook();

            Thread t1 = new Thread(ticketingBook.Booking);
            Thread t2 = new Thread(ticketingBook.Booking);
            Thread t3 = new Thread(ticketingBook.Booking);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
