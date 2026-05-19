using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.Employee
{

    [Table("SocialMediaInformation", Schema = "HR")]
    public class SocialMediaInformation : Base
    {
        public string? LinkedInUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? WebsiteUrl { get; set; }

        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }
    }
}
