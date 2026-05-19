using System.ComponentModel.DataAnnotations.Schema;

namespace HR_Management.Data.MasterData
{
    [Table("Religion", Schema = "Master")]
    public class Religion : Base
    {
        public string? ReligionName { get; set; }   // Islam, Hindu, Christian etc
    }
}
