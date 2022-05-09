using Microsoft.EntityFrameworkCore;
using Model;

namespace DataBaseAccess
{
    public class BDLabsDbContext : DbContext
    {
        public const string ConnectionString = "Server=localhost;Database=Course;Trusted_Connection=True;";
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
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseProduct> PurchaseProducts { get; set; }
    }
}