using EmployeeCQRS_AndMediatR.Model;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Queries
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
