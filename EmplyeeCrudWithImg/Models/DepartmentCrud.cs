using Microsoft.EntityFrameworkCore;

namespace EmplyeeCrudWithImg.Models
{
    public class DepartmentCrud
    {
        private readonly ApplicationDbContex db;
        public DepartmentCrud(ApplicationDbContex db) {
            this.db = db;

        }

        public List<Department1> GetDepartments() { 
            return db.department1s.ToList();
        }

        public Department1 GetDepartmentByid(int id) {
            return db.department1s.Where(x => x.DeptId == id).FirstOrDefault();
        }

        public int AddDepartment(Department1 department1) {
            int result = 0;
            db.department1s.Add(department1);
            result=db.SaveChanges();
            return result;
        }

        public int UpdateDepartment(Department1 department1) {
            int result = 0;
            var dept1 = db.department1s.Where(x => x.DeptId == department1.DeptId).FirstOrDefault();
            if (dept1 != null) { 
                dept1.DeptName= department1.DeptName;
                result=db.SaveChanges(); 
            }
            return result;
        }

        public int DeleteDepartment(int departmentId) {
            int result = 0;
            var dept1=db.department1s.Where(x=>x.DeptId==departmentId).FirstOrDefault();
            if (dept1 != null) {
                db.department1s.Remove(dept1);
                result=db.SaveChanges();
            }
            return result;
        }
    }
}
