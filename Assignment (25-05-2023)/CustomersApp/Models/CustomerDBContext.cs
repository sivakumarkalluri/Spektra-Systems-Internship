using Microsoft.EntityFrameworkCore;
namespace CustomersApp.Models
{
    public class CustomerDBContext:DbContext
    {
        public CustomerDBContext(DbContextOptions<CustomerDBContext> options)
       : base(options)
        {
        }

        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }

        public virtual DbSet<PurchaseData> PurchaseDatas { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CustomerDetail>()
      .HasOne(c => c.Purchases)
      .WithOne(p => p.Customer)
      .HasForeignKey<PurchaseData>(p => p.customerID);
        }


    }
    }

