using Microsoft.EntityFrameworkCore;

namespace EmployeeCQRS_AndMediatR.Model
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        public DbSet<Employee> Employees { get; set;}
    }
}
