using WebApiDemoTQ.Models;

namespace WebApiDemoTQ.Services
{
    public interface IEmployeeServices
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployee(int Id);
        int AddEmployee(Employee emp);
        int UpdateEmployee(Employee emp);
        int DeleteEmployee(int id);
    }
}
