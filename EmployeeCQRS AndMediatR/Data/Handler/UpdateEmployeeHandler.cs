using EmployeeCQRS_AndMediatR.Data.Command;
using EmployeeCQRS_AndMediatR.Model;
using EmployeeCQRS_AndMediatR.Service;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {;
            _employeeRepository = employeeRepository;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var model = await _employeeRepository.GetEmployeeById(request.Id);
            if (model == null) return default;
            model.FirstName = request.FirstName;
            model.LastName = request.LastName;
            model.Email = request.Email;
            model.Phone = request.Phone;
            model.Address = request.Address;
            return await _employeeRepository.UpdateEmployee(model);

        }
    }
}
