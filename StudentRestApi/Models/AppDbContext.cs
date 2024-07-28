using Microsoft.EntityFrameworkCore;

namespace StudentRestApi.Models
{
    public class AppDbContext : DbContext
    {
       /* public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }*/

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
