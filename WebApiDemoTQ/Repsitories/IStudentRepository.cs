using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Repsitories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        int AddStudent(Student stu);
        int UpdateStudent(Student stu);
        int DeleteStudent(int id);
    }
}
