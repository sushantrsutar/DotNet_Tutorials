using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableDemoTQ
{
    public class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee() { }
        public Employee(int Id,string Name,double Salary) {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;

        }

        public override string ToString() {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary}";
        }
    }

    public class Idcompare : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.Id > y.Id)
            {
                return 1;
            }
            else if (x.Id < y.Id)
            {
                return -1;
            }
            else {
                return 0;
            }
        }
    }

    public class Namecompare : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class SalaryCompare : IComparer<Employee> {
        public int Compare(Employee x, Employee y) { 
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
