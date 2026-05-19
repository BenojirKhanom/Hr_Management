using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.MasterData
{
    [Table("Designation", Schema = "Master")]
    public class Designation : Base
    {
        public string? DesignationName { get; set; }
        public string? DesignationCode { get; set; }
    }
}
