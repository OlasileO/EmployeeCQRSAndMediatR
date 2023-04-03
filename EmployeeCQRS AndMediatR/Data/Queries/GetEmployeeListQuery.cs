using EmployeeCQRS_AndMediatR.Model;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Queries
{
    public class GetEmployeeListQuery:IRequest<List<Employee>>
    {
    }
}
