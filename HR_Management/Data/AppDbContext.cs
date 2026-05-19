using Microsoft.EntityFrameworkCore;

namespace HR_Management.Data
{
    public class AppDbContext: DbContext

    {
      public AppDbContext(DbContextOptions <AppDbContext> option)
            :base(option)
        {

        }
    }
}
