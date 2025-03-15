using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignmentTQ
{    //4.Create a class User with parametric constructor to accept a user name.
    //Create User defined Exception class as NameException.In user class check condition as,
    //If user name is null or empty in the parameter of constructor, raise an exception &
    //display error message as “Name is required”.
    public class NameException : Exception { 
        public NameException(string msg):base(msg) { }
    }
    public class Name
    {
        string name;
        //public Name() {
        //    throw new NameException("Name is required ");
        //}   
        public Name(string name)
        {
            if (name == null)
            {
                throw new NameException("Name is required ");
            }
            else
            {
                this.name = name;
            }
            Console.WriteLine(name);
        }
        
    }
}
