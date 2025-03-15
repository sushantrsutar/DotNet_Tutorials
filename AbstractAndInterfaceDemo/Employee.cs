using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaceDemo
{
    /*"1.Create a class Department having did, deptName
Create a class Employee having eid, empName, salary and department
Create 3 objects
  > 1.using anonymous department
  > 2. using department object : using contsructor
  > 3. using getter and setter: giving values from your own
check the hashcode generated for department in 1st and 2 nd object
Also print the details of all Employees*/
    class Department {
        int dId { set; get; }
        string dName { set; get; }

        public Department() { }

        public Department(int dId,string dname) { 
            this.dId = dId; 
            this.dName = dname;
        }
        public override string ToString()
        {
            return $"Department id : {dId} , Department Name : {dName}";
        }
    }
    class Employee
    {
        int Eid { set; get; }
        string Ename { set; get; }
        double Esalary { set; get; }
        Department Department { set; get; }

        public Employee() { }
        public Employee(int eId,string eName,double eSalary,Department department) { 
            this .Eid = eId;    
            this .Ename = eName;
            this .Esalary = eSalary;
            this .Department = department;
        }

        public override string ToString() {
            return $"Id : {Eid} , Name : {Ename} , Salary : {Esalary} , Department : {Department}";
        }
    }
}
