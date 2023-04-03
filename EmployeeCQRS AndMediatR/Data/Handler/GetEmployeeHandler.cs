using EmployeeCQRS_AndMediatR.Data.Queries;
using EmployeeCQRS_AndMediatR.Model;
using EmployeeCQRS_AndMediatR.Service;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Handler
{
    public class GetEmployeeHandler : IRequestHandler<GetEmployeeListQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> Handle(GetEmployeeListQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepository.GetEmployeesList();
        }
    }
}
