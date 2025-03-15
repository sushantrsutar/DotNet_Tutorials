using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersDemo
{
    public class class1{
        public void show() {
            Console.WriteLine(new Employee().name);
        }
    }

    class Developer : Employee {
        public void show() {
            Console.WriteLine(name);
        }
    }

}
