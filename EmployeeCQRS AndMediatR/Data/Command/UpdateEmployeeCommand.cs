using EmployeeCQRS_AndMediatR.Model;
using MediatR;

namespace EmployeeCQRS_AndMediatR.Data.Command
{
    public class UpdateEmployeeCommand:IRequest<int>
    {
        public UpdateEmployeeCommand(int id,string firstName, string lastName,
            string email, string phone, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
           
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
