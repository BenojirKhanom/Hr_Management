using HR_Management.Data.Employee;
using HR_Management.Data.MasterData;
using Microsoft.EntityFrameworkCore;

namespace HR_Management.Data
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options)
        : base(options)
        {
        }

        #region EmployeeInfo
        public DbSet<EmployeeInfo>  employeeInfos { get; set; }
        public DbSet<EmploymentDetails> EmploymentDetails { get; set; }
        public DbSet<ParentsInformation> ParentsInformation { get; set; }
        public DbSet<SocialMediaInformation>   socialMediaInformation { get; set; }
        #endregion
        #region MasterData
        public DbSet<Department> Department { get; set; }
        public DbSet<Designation> Designation { get; set; }
        public DbSet<BloodGroup> BloodGroup { get; set; }
        public DbSet<Religion> Religion { get; set; }
        #endregion


    }
}
