using HR_Management.Data.MasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.Employee
{

    [Table("EmployeeInfo", Schema = "HR")]
    public class EmployeeInfo :Base
    {
        public string? EmpCode { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? NationalId { get; set; }
        public string? PassportNo { get; set; }
        public string? BirthIdentificationNo { get; set; }
        public string? Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public string? MobileNumber { get; set; }
        public string? ImagePath { get; set; }
        public string? TINNo { get; set; }

        public int ? bloodGroupId { get; set; }
        public BloodGroup bloodGroup { get; set; }

        public int? designationId { get; set; }
        public Designation  designation { get; set; }


        public int? departmentId { get; set; }
        public Department  department { get; set; }


        public int? religionId { get; set; }
        public Religion  religion { get; set; }



    }
}
