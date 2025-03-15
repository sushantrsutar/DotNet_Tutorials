using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDwithImage.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DisplayName("Category Id")]
        public int CategoryId { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string? CategoryName { get; set; }
    }
}
