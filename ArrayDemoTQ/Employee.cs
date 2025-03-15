using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*"1.WAP to print the employees from Employee[] array who has same salary 
 * (Create Employee class which has 3 attributes id, name, salary, skill[]
 * and add employee objects to your array)
Find the employee with highest salary*/
namespace ArrayDemoTQ
{   
    internal class Employee
    {
        public int EmpId { set; get; }
        public string EmpName { set; get; }
        public double EmpSalary { set; get; }
        public string[] EmpSkills { set; get; }

        public Employee(int EmpId, string EmpName, double EmpSalary, string[] EmpSkills) { 
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
            this.EmpSkills = EmpSkills;
        }

        public override string ToString()
        {
            string skills = string.Join(", ", EmpSkills);
            return $"EmpId : {EmpId} , EmpName : {EmpName} , EmpSalary : {EmpSalary} , EmpSkills : {skills}";
        } 
    
    }
}
