using System.ComponentModel.DataAnnotations;

namespace ASPDemoTQ.Models
{
    public class Student
    {
        /*Create Student Class, apply data annotation & create controller and action
        Generate the View & check validations

        Roll No - required
        Name - required, max - 20, min -2 only chars
        Age
        Address
        Branch
        Percentage
        DOB  → DataType.Date
        */
        [Display(Name ="Roll no:")]
        [Required(ErrorMessage ="Enter roll number")]
        public int RollNo { get; set; }

        [Required(ErrorMessage ="Enter Name")]
        [MinLength(3)]
        [MaxLength(20)]
        [RegularExpression(@"[a-zA-z]*$",ErrorMessage ="Enter only text")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="enter age")]
        [Range(6,45,ErrorMessage ="Enter age between 6 to 45")]
        public int Age { set; get; }

        [Required(ErrorMessage ="Enter Address")]
        [MaxLength(200)]
        [MinLength(20)]
        public string? Address { get; set; }

        [Required(ErrorMessage ="Enter Barnch Name")]
        [Display(Name ="Branch Name")]
        [MinLength(2)]
        [MaxLength(15)]
        public string? Baranch { get; set; }

        [Required(ErrorMessage ="Enter Percentage")]
        [Range(1,100,ErrorMessage ="Enter Valide Percentage ")]
        public double Percentage { get; set; }

        [Required(ErrorMessage ="Enter DOB")]
        [DataType(DataType.Date)]
        [Display(Name ="Date Of Birth")]
        public string? DOB { get; set; }

    }
}
