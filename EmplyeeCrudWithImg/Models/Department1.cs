using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmplyeeCrudWithImg.Models
{
    [Table("Department1")]
    public class Department1
    {
        [Key]
        public int DeptId { set; get; }
        public string? DeptName { set; get; }
    }
}
