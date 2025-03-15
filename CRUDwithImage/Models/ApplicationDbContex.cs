using Microsoft.EntityFrameworkCore;

namespace CRUDwithImage.Models
{
    public class ApplicationDbContex:DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> op) : base(op)
        {

        }

        public DbSet<Category>Categories { get; set; }
        public DbSet<Product1>Product1s { get; set; }
    }
}
