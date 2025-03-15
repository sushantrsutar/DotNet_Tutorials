using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignmentTQ
{   //5.Use the same above user class. Add method AcceptAge to read age from parameter.
    //Create one user defined exception class AgeException.
    //If user has age less than 18 then display message as “driving license can not be issued”
    //else display message as “driving license will be issued”
     class User
    {   
        public User() { }
        public void AcceptAge(int age) {
            if (age < 18)
            {
                throw new AgeException("driving license can not be issued");
            }
            else {
                Console.WriteLine("driving license issued");
            }
        }
    }
    public class AgeException:Exception
    {
        public AgeException(string msg):base(msg) { }
    }

}
