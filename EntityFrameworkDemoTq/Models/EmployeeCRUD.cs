namespace EntityFrameworkDemoTq.Models
{
    public class EmployeeCRUD
    {
        private readonly ApplicationDbContex db;
        public EmployeeCRUD(ApplicationDbContex db) { 
            this.db = db;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            // LINQ
            var result = from emp in db.Employees
                         select emp;
            return result;
            // Lambda
            //return db.Employees.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            //LINQ
            var result = (from emp in db.Employees
                          where emp.EmpId == id
                          select emp).FirstOrDefault();
            return result;

            //Lambda
             //return db.Employees.Where(x => x.EmpId == id).FirstOrDefault();
        }
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            db.Employees.Add(emp); // added data in DbSet
            result = db.SaveChanges(); // reflect the changes in DB
            return result;
        }
        public int UpdateEmployee(Employee emp)// new data
        {
            int result = 0;
            var e1 = db.Employees.Where(x => x.EmpId == emp.EmpId).FirstOrDefault(); // get old data from table
            if (e1 != null)
            {
                e1.EmpName = emp.EmpName;  // override the values
                e1.EmpSalary = emp.EmpSalary;
                result = db.SaveChanges();
            }
            return result;
        }
        public int DeleteEmployee(int id)
        {
            int result = 0;
            var e1 = db.Employees.Where(x => x.EmpId == id).FirstOrDefault();
            if (e1 != null)
            {
                db.Employees.Remove(e1); // removes the object from DbSet
                result = db.SaveChanges(); // reflect the changes in DB
            }
            return result;
        }


    }
}
