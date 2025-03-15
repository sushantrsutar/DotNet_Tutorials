using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Repsitories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee>GetEmployees();
        Employee GetEmployee(int Id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
