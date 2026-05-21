using HR_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Data
{
    public class AppDbContext: DbContext

    {
      public AppDbContext(DbContextOptions <AppDbContext> option)
            :base(option)
        {

        }
        public DbSet<EmployeeDitailse> Employee_Ditailse { get; set; }

        public DbSet<EmployeeSocialMedia> EmployeeSocialMedia { get; set; }
    }
}
