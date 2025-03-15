using Microsoft.EntityFrameworkCore;

namespace EmplyeeCrudWithImg.Models
{
    public class ApplicationDbContex:DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> op) : base(op)
        {

        }
        public DbSet<Department1>department1s { get; set; }
        public DbSet<Employee1> employee1s { get; set; }
    }
}
