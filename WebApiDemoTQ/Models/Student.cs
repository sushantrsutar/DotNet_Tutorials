using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemoTQ.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Required]
        public int StuId { get; set; }

        [Required]
        public String? StuName { get; set; }

        [Required]

        public int StuAge { get; set; }

        [Required]
        public int StuPercentage { get; set; }
    }
}
