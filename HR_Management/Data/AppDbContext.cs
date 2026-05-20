using Microsoft.EntityFrameworkCore;

namespace HR_Management.Data
{
    public class AppDbContext: DbContext

    {
      public AppDbContext(DbContextOptions <AppDbContext> option)
            :base(option)
        {

        }
        public DbSet<Models.Employee_Ditailse> Employees { get; set; }
        public DbSet<Models.EmployeeSocialMedia> EmployeeSocialMedias { get; set; }
    }
}
