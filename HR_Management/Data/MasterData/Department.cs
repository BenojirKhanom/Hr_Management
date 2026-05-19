using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.MasterData
{
    [Table("Department", Schema = "Master")]
    public class Department : Base
    {
        public string? DepartmentName { get; set; }
        public string? DepartmentCode { get; set; }
    }
}
