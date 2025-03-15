using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiDemoTQ.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        [Required]
        public string? EmpName{ get; set; }

        [Required]
        public int  EmpAge { get; set; }

        [Required]
        public int EmpSalary { get; set; }
    }
}
