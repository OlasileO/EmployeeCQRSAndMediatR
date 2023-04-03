using EmployeeCQRS_AndMediatR.Model;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Command
{
    public class DeleteEmployeeCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
