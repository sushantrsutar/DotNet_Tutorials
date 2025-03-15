using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemoTq.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { set; get; }

        [Required(ErrorMessage = "Enter Movie name")]
        public string? MovieName { set; get; }

        [Required(ErrorMessage ="Enter Actor name")]
        public string? ActorName { set; get; }

        [Required(ErrorMessage = "Enter Producer name")]
        public string? ProducerName { set; get; }
    }
}
