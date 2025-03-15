using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    /*"1.Write Employee Class with attributes like employeeid, name, and salary. 
     * Create parameterized constructor to initialize this 3 attributes, 
     * and write a method to display this information of 5 objects, 
     * display total no of employees using static method, TotalEmp(), which will return total no of employees.
     * Also note there should be auto-generation of employeeid.
*/
    internal class EmployeeStatic
    {
        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public double EmployeeSalary { set; get; }

        public static int EmployeeCount=0;

        public static int EmpId = 1;
        public EmployeeStatic(String name,Double salary) {
            this.EmployeeId = EmpId++;
            this.EmployeeName = name;
            this.EmployeeSalary = salary;
            EmployeeCount++;

        }

        public String show() {
            return $"Employee Id : {EmployeeId} , Employee Name : {EmployeeName} , Employee Salary : {EmployeeSalary}";
        }



    }
}
