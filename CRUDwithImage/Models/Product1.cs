using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDwithImage.Models
{
    [Table("Product1")]
    public class Product1
    {
        [Key]
        [DisplayName("Product Id")]
        public int productId { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string? productName { set; get; }

        [Required]
        [DisplayName("Product Price")]
        public int price { set; get; }

        [DisplayName("Image")]
        public string? imageUrl { set; get;  }

        [Required]
        [DisplayName("Category Id")]
        public int categoryId { set; get;  }

        [NotMapped]
        [DisplayName("Category Name")]
        public string? CategoryName { get; set; }
    }
}
