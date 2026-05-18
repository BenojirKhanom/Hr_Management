using HR_Management.Data.Employee;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Data
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
        : base(options)
        {
        }

        public DbSet<EmployeeInfo>  employeeInfos { get; set; }
    
    }
}
