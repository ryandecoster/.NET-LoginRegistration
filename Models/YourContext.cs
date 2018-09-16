using Microsoft.EntityFrameworkCore;

namespace Partials.Models
{
    public class YourContext : DbContext
    {
        public YourContext(DbContextOptions<YourContext> options) : base(options) {}
        public DbSet<User> Users { get; set; } 
    }
}