using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.MasterData
{
    [Table("BloodGroup", Schema = "Master")]
    public class BloodGroup : Base
    {
        public string? BloodGroupName { get; set; }   // A+, B-, O+ etc
    }
}
