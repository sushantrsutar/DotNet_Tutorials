using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Program
    {
        abstract class Person {
            //static data is created only once
            static public ulong count = 0UL;
            public Person() {
                count++;
            }

        }

        class Doctor : Person{ 
            public Doctor() : base() {
            
            }
        }

        class Patient : Person{
            public Patient() : base()
            {

            }
        
        }
        static void Main(string[] args)
        {
                Doctor doctor1 = new Doctor();
                Doctor doctor2 = new Doctor();

                Patient patient1 = new Patient();
                Patient patient2 = new Patient();

                Console.WriteLine($"Total persons : {Person.count}");
                //Console.WriteLine($"Total persons : {Doctor.count}");


        }
    }
}
