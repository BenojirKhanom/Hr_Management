using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.Employee
{

    [Table("ParentsInformation", Schema = "HR")]
    public class ParentsInformation : Base
    {
        public string? FathersName { get; set; }
        public string? FathersNID { get; set; }
        public string? FathersPassportNo { get; set; }
        public string? FathersMobile { get; set; }

        public string? MothersName { get; set; }
        public string? MothersNID { get; set; }
        public string? MothersPassportNo { get; set; }
        public string? MothersMobile { get; set; }

        public int? employeeId { get; set; }
        public EmployeeInfo employee { get; set; }

    }
}
