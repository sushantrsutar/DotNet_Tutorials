using System.ComponentModel.DataAnnotations;

namespace ADOCRUDdemoTQ.Models
{
    public class Employee
    {
        [Key]//primary key col
        public int EmpId { get; set; }
        [Required]
        public string? EmpName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
