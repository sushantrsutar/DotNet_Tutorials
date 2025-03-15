using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemoTq.Models
{
    public class ApplicationDbContex:DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex>op):base(op) { 
            
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Student>Students { get; set; }
        public DbSet<Movie>Movies { get; set; }
    }
}
