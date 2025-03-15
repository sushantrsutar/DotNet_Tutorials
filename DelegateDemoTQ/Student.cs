using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemoTQ
{
    public delegate void Mydelegate1();
    internal class Student
    {
        public event Mydelegate1 pass;
        public event Mydelegate1 fail;
        public void AcceptMarks(double marks) {
            if (marks >= 35)
            {
                pass();
            }
            else {
                fail();
            }
        }
    }
    public class Massage {
        public void PassMsg() {
            Console.WriteLine("Your Pass");
        }

        public void FailMsg() {
            Console.WriteLine("Your Fail");
        }
    }
}
