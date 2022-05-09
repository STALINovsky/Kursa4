using Microsoft.EntityFrameworkCore;
using Model;

namespace DataBaseAccess
{
    public class BDLabsDbContext : DbContext
    {
        public const string ConnectionString = "Server=(localdb)\\mssqllocalDb;Database=Course;Trusted_Connection=True;";
        public BDLabsDbContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Emploee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Books { get; set; }
        public DbSet<PurchaseProduct> OrderedBooks { get; set; }
    }
}