using EmployeeCQRS_AndMediatR.Data.Queries;
using EmployeeCQRS_AndMediatR.Model;
using EmployeeCQRS_AndMediatR.Service;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Handler
{
    public class GetByIdEmployeeHandler : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetByIdEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeeById(request.Id);
        }
    }
}
