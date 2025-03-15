using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{   /*2. Write a C# program to create a class known as Person with methods called GetFirstName() and GetLastName(). 
     * Create a subclass called Employee that adds a new method named GetEmployeeId() and
     * overrides the GetLastName() method to include the employee's job title.*/
    public  class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string GetFirstName()
        {
            return FirstName;
        }

        public virtual string GetLastName()
        {
            return LastName;
        }
    }

    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public int EmployeeId { get; set; }

        public Employee(string firstName, string lastName, string jobTitle, int employeeId)
            : base(firstName, lastName)
        {
            JobTitle = jobTitle;
            EmployeeId = employeeId;
        }
        public override string GetLastName()
        {
            return $"{LastName} , {JobTitle}";
        }
        public string GetEmployeeId()
        {
            return $"Employee ID: {EmployeeId}";
        }
    }
}
