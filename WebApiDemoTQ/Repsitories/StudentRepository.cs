using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Repsitories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext dbs;

        public StudentRepository(ApplicationDbContext dbs) { 
            this.dbs = dbs;
        }
        public int AddStudent(Student stu)
        {
            int result = 0;
            dbs.students?.Add(stu);
            result=dbs.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stu = dbs.students.Where(x => x.StuId == id).FirstOrDefault();
            if (stu != null) { 
                dbs.students.Remove(stu);
                result=dbs.SaveChanges();
            }
            return result;
        }

        public IEnumerable<Student> GetAllStudents()
        {
           var stu=dbs.students?.ToList();
            return stu;
        }

        public Student GetStudentById(int id)
       {
            var stu= dbs.students?.FirstOrDefault(x => x.StuId == id);
            return stu;
        }

        public int UpdateStudent(Student s)
        {
            int result = 0;
            var stu = dbs.students.Where(x => x.StuId == s.StuId).FirstOrDefault();
            if (stu != null) { 
                stu.StuName = s.StuName;
                stu.StuAge = s.StuAge;
                stu.StuPercentage = s.StuPercentage;
                result=dbs.SaveChanges();
            }
            return result;
            
        }
    }
}
