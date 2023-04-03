using EmployeeCQRS_AndMediatR.Data.Command;
using EmployeeCQRS_AndMediatR.Model;
using EmployeeCQRS_AndMediatR.Service;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Handler
{
    public class CreateEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emp = new Employee 
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Address = request.Address,
                Phone = request.Phone,
                Email = request.Email,
            };
            return await _employeeRepository.AddEmployee(emp);
        }
    }
}
