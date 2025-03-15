using Microsoft.EntityFrameworkCore;

namespace WebApiDemoTQ.Models
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>op) : base(op) { 
            
        }

       public  DbSet<Employee>?employees { get; set; }

    }
}
