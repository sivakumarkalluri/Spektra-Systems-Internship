using Microsoft.EntityFrameworkCore;
namespace ProductsAPI.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
       : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } 

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
