using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsDemoTQ
{
    internal class Employee
    {
        public int empid { set; get; }
        public string empname { set; get; }
        public double empsalary {  set; get; }

        public string show() {
            return $"Id : {empid},Name : {empname},Salary : {empsalary}";
        }
    }
}
