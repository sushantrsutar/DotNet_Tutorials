using System.ComponentModel.DataAnnotations;

namespace ASPDemoTQ.Models
{
    public class Employee
    {
        [Display(Name ="Employee Id")]
        [Required(ErrorMessage ="ID is required")]
        //[DataType(DataType.Text)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name Required")]
        [MaxLength(20)]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]*$",ErrorMessage ="Enter only text")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        [Display(Name ="Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm password dose not match")]
        public string? ConfirmPassword { get;  set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(18,60,ErrorMessage ="Age should be between 18 to 60")]
        public int age { set; get; }
    }
}
