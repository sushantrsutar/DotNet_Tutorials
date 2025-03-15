using WebApiDemoTQ.Models;
using WebApiDemoTQ.Repsitories;

namespace WebApiDemoTQ.Services
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly IEmployeeRepository repo;

        public EmployeeService(IEmployeeRepository repo)//added repository dependency
        { 
            this.repo = repo;
        }
        public int AddEmployee(Employee emp)
        {
           return repo.AddEmployee(emp);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public Employee GetEmployee(int Id)
        {
            return repo.GetEmployee(Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee emp)
        {
            return repo.UpdateEmployee(emp);
        }
    }
}
