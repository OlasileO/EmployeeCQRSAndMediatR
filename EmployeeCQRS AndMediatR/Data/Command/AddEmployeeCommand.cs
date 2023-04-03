using EmployeeCQRS_AndMediatR.Model;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Command
{
    public class AddEmployeeCommand:IRequest<Employee>
    {
        public AddEmployeeCommand(string firstName, string lastName,
            string email, string phone, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
