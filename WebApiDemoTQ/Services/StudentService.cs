using WebApiDemoTQ.Models;
using WebApiDemoTQ.Repsitories;

namespace WebApiDemoTQ.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository srepo;

        public StudentService(IStudentRepository srepo) { 
            this.srepo = srepo;
        }
        public int AddStudent(Student stu)
        {
            return srepo.AddStudent(stu);
        }

        public int DeleteStudent(int id)
        {
            return srepo.DeleteStudent(id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return srepo.GetAllStudents();
        }

        public Student GetStudentById(int Id)
        {
            return srepo.GetStudentById(Id);
        }

        public int UpdateStudent(Student stu)
        {
            return srepo.UpdateStudent(stu);
        }
    }
}
