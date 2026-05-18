using System.ComponentModel.DataAnnotations;
namespace HR_Management.Data
{
    public class Base
    {
        [Key]
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
