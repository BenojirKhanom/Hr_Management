using HR_Management.Data.MasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.Employee
{

    [Table("EmploymentDetails", Schema = "HR")]
    public class EmploymentDetails : Base
    {
        public DateTime? JoiningDate { get; set; }
        public string? ActivityStatus { get; set; }
        public string? BranchName { get; set; }
        public string? EmployeeStatus { get; set; } // Permanent / Contract
        public int? employeeId { get; set; }
        public EmployeeInfo   employee { get; set; }

        public int? designationId { get; set; }
        public Designation designation { get; set; }

        public int? departmentId { get; set; }
        public Department department { get; set; }



    }
}
