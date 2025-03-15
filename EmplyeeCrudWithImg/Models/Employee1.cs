using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmplyeeCrudWithImg.Models
{
    [Table("Employee1")]
    public class Employee1
    {
        [Key]
        public int EmpId { get; set; }

        public string? EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string? EmpImage { get; set; }

        public int DeptId { get; set; }

        [NotMapped]
        public string? DeptName { get; set; }
    }
}
