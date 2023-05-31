using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment2
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        public DbSet<StudentDetails> Students { get; set; }
        public DbSet<Marks> Mark { get; set; }

        public DbSet<Top20Rank> Top20Ranks { get; set;}

    }
}
