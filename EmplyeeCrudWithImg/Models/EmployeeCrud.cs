namespace EmplyeeCrudWithImg.Models
{
    public class EmployeeCrud
    {
        private readonly ApplicationDbContex db;

        public EmployeeCrud(ApplicationDbContex db) {
            this.db = db;
        }

        public IEnumerable<Employee1> GetEmployees() { 
            var model= (from d in db.department1s
                        join
                        e in db.employee1s
                        on d.DeptId equals e.DeptId
                        select new Employee1
                        {
                            EmpId = e.EmpId,
                            EmpName = e.EmpName,
                            EmpSalary = e.EmpSalary,
                            EmpImage = e.EmpImage,
                            DeptId = d.DeptId,
                            DeptName = d.DeptName
                        }).ToList();

            return model;
        }

        public Employee1 GetEmployeeById(int id) {
            return db.employee1s.Where(x => x.EmpId == id).FirstOrDefault();
        }

        public int AddEmpoyee(Employee1 employee1) {
            int result = 0;
            db.employee1s.Add(employee1);
            result=db.SaveChanges();
            return result;
        }

        public int UpadateEmployee(Employee1 employee1) {
            int result = 0;
            var emp1=db.employee1s.Where(x=>x.EmpId==employee1.EmpId).FirstOrDefault();
            if (emp1 != null) { 
                emp1.EmpName = employee1.EmpName;
                emp1.EmpSalary = employee1.EmpSalary;
                emp1.EmpImage= employee1.EmpImage;
                emp1.DeptId = employee1.DeptId;
                result=db.SaveChanges();
            }
            return result;
        }

        public int DeleteEmployee(int id) {
            int result = 0;
            var emp1=db.employee1s.Where(x=>x.EmpId==id).FirstOrDefault();
            if (emp1 != null) { 
                db.employee1s.Remove(emp1);
                result=db.SaveChanges();
            }
            return result;
        }
    }
}
