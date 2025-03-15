using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal class Program
    {
        interface Person {
             string name { set; get; }
             int age { set; get; }

            string GetName();
            int GetAge();
        }
        class Employee : Person
        {
            public string name { set; get; }=string.Empty;  
            public int age { set; get; }

            public string GetName() { 
                return name;
            }

            public int GetAge(){
                return age;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
