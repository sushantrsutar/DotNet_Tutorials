using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemoTq.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string? EmpName { get; set; }
        [Required]
        public int EmpSalary { get; set; }
    }
}
