using EmployeeCQRS_AndMediatR.Model;

namespace EmployeeCQRS_AndMediatR.Service
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetEmployeesList();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employee);
        Task<int> DeleteEmployee(int id);
    }
}
