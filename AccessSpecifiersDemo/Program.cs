using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersDemo

{
    public class Employee
    {
        private int a;
        public int b;
        protected int c;
        internal int d;
        protected internal int e;
        private protected int f;
        protected internal string name = "Thor";

    }

    class Test {
        public void test() { 
            Employee employee = new Employee();
            //Console.WriteLine(employee.a);//private
            Console.WriteLine(employee.b);//public
            //Console.WriteLine(employee.c);//protected
            Console.WriteLine(employee.d);//internal
            Console.WriteLine(employee.e);//protected internal
            //Console.WriteLine(employee.f);//private protected

        }
    }
    class Manager : Employee
    {
        public void show()
        {
            Console.WriteLine(name);
        }
        public void test1()
        {
            Employee employee = new Employee();
            //Console.WriteLine(employee.a);//private
            Console.WriteLine(employee.b);//public
           // Console.WriteLine(employee.c);//protected
            Console.WriteLine(employee.d);//internal
            Console.WriteLine(employee.e);//protected internal
            //Console.WriteLine(employee.f);//private protected

        }
    }
    internal class Program
    {
        private protected string name = "Jack";
        static void Main(string[] args)
        {
            Program p=new Program();
            Console.WriteLine(p.name);

            //Employee e1= new Employee();
            //Console.WriteLine(e1.name);

            class1 class1 = new class1();
            class1.show();

           
        }
    }
}
