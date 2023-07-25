using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Add DbSet properties here for your entities (when you create them later)
        // For example:
        // public DbSet<Product> Products { get; set; }
    }
}
