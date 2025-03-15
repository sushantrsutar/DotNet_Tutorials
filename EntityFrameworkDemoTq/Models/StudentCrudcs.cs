using System.Security.Cryptography.Xml;

namespace EntityFrameworkDemoTq.Models
{
    public class StudentCrudcs
    {
        private readonly ApplicationDbContex db;
        public StudentCrudcs(ApplicationDbContex db) { 
            this.db = db;

        }

        public IEnumerable<Student> GetStudents() { 
            return db.Students.ToList();
        }

        public Student GetStudentById(int id) {
            return db.Students.Where(x => x.StuId == id).FirstOrDefault();
        }

        public int AddStudent(Student stu) {
            int result = 0;
            db.Students.Add(stu);
            result = db.SaveChanges();
            return result;

        }
        public int UpdateStudent(Student stu) {
            int result = 0;
            var s1=db.Students.Where(x=>x.StuId==stu.StuId).FirstOrDefault();
            if (s1 != null) { 
                s1.StuName=stu.StuName;
                s1.StuMarks=stu.StuMarks;
                s1.StuGrade=stu.StuGrade;
                result = db.SaveChanges();
            }
            return result;
        }

        public int DeleteStudent(int id) {
            int result = 0;
            var e1 = db.Students.Where(x => x.StuId == id).FirstOrDefault();
            if (e1 != null) { 
                db.Students.Remove(e1);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
