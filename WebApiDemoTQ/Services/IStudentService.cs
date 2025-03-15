using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int Id);
        int AddStudent(Student stu);
        int UpdateStudent(Student stu);
        int DeleteStudent(int id);
    }
}
