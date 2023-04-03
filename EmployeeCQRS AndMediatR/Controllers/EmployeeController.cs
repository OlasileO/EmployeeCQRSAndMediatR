using EmployeeCQRS_AndMediatR.Data.Command;
using EmployeeCQRS_AndMediatR.Data.Queries;
using EmployeeCQRS_AndMediatR.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;



namespace EmployeeCQRS_AndMediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IMediator _Mediator;

        public EmployeeController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Employee>> EmployeeList()
        {
            var emlpoyeelist = await _Mediator.Send(new GetEmployeeListQuery());
            return emlpoyeelist;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            var employeeById = await _Mediator.Send(new GetEmployeeByIdQuery() {Id=id });
            return employeeById;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var addEmployee = await _Mediator.Send(new AddEmployeeCommand(
                employee.FirstName,
                employee.LastName,
                employee.Email,
                employee.Phone,
                employee.Address
                ));
            return addEmployee;
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var updateEmployee = await _Mediator.Send(new UpdateEmployeeCommand(
               employee.Id,
                employee.FirstName,
               employee.LastName,
               employee.Email,
               employee.Phone,
               employee.Address
               ));
            return updateEmployee;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _Mediator.Send(new DeleteEmployeeCommand() { Id = id });
        }
    }
}
