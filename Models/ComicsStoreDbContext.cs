using Microsoft.EntityFrameworkCore;
namespace ComicsStore.Models
{
    public class ComicsStoreDbContext : DbContext
    {
        public ComicsStoreDbContext(DbContextOptions<ComicsStoreDbContext>
        options) : base(options) { }
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}