using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntityFrameworkDemoTq.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StuId { set; get; }

        [Required(ErrorMessage ="Enter Name")]
        public string? StuName { set; get; }

        [Required (ErrorMessage ="Enter marks")]
        public int StuMarks { set; get; }

        [Required (ErrorMessage ="Enter grade")]
        public string? StuGrade { set; get; }
    }
}
