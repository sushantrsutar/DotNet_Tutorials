using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifiersDemo;

namespace otherNameSpace
{   class NormalClass {
        public void test()
        {
            //Employee employee = new Employee();
            //Console.WriteLine(employee.a);//private
            //Console.WriteLine(employee.b);//public
            //Console.WriteLine(employee.c);//protected
            //Console.WriteLine(employee.d);//internal
            //Console.WriteLine(employee.e);//protected internal
            //Console.WriteLine(employee.f);//private protected

        }

    }

    class Programer : Employee {
        public void test()
        {
            //Employee employee = new Employee();
            //Console.WriteLine(employee.a);//private
            //Console.WriteLine(employee.b);//public
            //Console.WriteLine(employee.c);//protected
            //Console.WriteLine(employee.d);//internal
            //Console.WriteLine(employee.e);//protected internal
            //Console.WriteLine(employee.f);//private protected

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
