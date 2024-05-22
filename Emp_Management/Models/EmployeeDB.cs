using Microsoft.EntityFrameworkCore;


namespace Emp_Management.Models
{
    public class EmployeeDB:DbContext
    {
        public EmployeeDB(DbContextOptions option):base(option) 
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
