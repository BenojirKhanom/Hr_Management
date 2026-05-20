using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HR_Management.Models
{
    public class EmployeeSocialMedia
    {
        public int Id { get; set; }
        public string LinkedInProfileURL { get; set; }
        public string FacebookProfileURL { get; set; }
        public string TwitterHandleURL { get; set; }
        public string InstagramHandleURL { get; set; }
        public string GitHubProfileURL { get; set; }
        public string PortfolioURL { get; set; }

    }
}
