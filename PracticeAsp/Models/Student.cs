using System.ComponentModel.DataAnnotations;

namespace PracticeAsp.Models
{
    public class Student
    {
        [Display(Name ="Student Id")]
        [Required(ErrorMessage ="Enter Id")]
        
        public int Id { get; set; }

        [Display(Name ="Student Name")]
        [RegularExpression(@"^[a-zA-Z]*$",ErrorMessage ="Enter Valide name")]
        [Required(ErrorMessage ="Enter Name")]
        [MinLength(2)]
        [MaxLength(30)]

        public string? Name { get; set; }

        [Display(Name ="Student Age")]
        [Required(ErrorMessage ="Enter Age")]
        [Range(6,35,ErrorMessage ="Enter age between 6 to 36 ")]

        public int Age { set; get; }

        [Required(ErrorMessage ="Enter Email")]
        [Display(Name ="Student Email")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter Valide Email")]
        public string? Email { set; get; }
    }
}
