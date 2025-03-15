using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Program
    {
        interface IPerson {
            string who();
        }

        class Employee : IPerson {
            public string who() {
                return ToString().Split('.')[1];
            }
        
        }

        class Manager : IPerson{
            public string who()
            {
                return ToString().Split('.')[1];
            }
        }
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //Console.WriteLine(emp.who()) ;


            IPerson person = new Employee();
            Console.WriteLine(person.who()) ;

            person = new Manager();
            Console.WriteLine(person.who()) ;

        }
    }
}
