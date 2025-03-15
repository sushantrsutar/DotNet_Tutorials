using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Repsitories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;

        public EmployeeRepository(ApplicationDbContext db)//added the dependecies
        { 
            this.db = db;
        }
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            db.employees?.Add(emp);
            result=  db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int result = 0;
            var emp = db.employees?.Where(x => x.EmpId == id).FirstOrDefault();
            if (emp != null) { 
                db.employees.Remove(emp);
                result = db.SaveChanges();
            }
            return result;
        }

        public Employee GetEmployee(int Id)
        {
            
            var emp=db.employees?.Where(x=>x.EmpId==Id).FirstOrDefault();
            return emp;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.employees.ToList();
        }

        public int UpdateEmployee(Employee e)
        {
            int result = 0;
            var emp=db.employees.Where(x=>x.EmpId==e.EmpId).FirstOrDefault();
            if (emp != null) { 
                emp.EmpName = e.EmpName;
                emp.EmpAge = e.EmpAge;
                emp.EmpSalary=e.EmpSalary;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
