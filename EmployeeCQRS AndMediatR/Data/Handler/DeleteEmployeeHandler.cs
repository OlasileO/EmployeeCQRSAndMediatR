using EmployeeCQRS_AndMediatR.Data.Command;
using EmployeeCQRS_AndMediatR.Service;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Handler
{
    public class DeleteEmployeeHandler:IRequestHandler<DeleteEmployeeCommand , int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var model = await _employeeRepository.GetEmployeeById(request.Id);
            if (model == null) return default;
            return await _employeeRepository.DeleteEmployee(model.Id);
        }
    }
}
