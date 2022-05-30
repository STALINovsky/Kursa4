using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;

namespace DataBaseAccess
{
    public partial class BDLabsDbContext : DbContext
    {
        public BDLabsDbContext()
        {
            Manufacturers.Load();
            Providers.Load();
            Components.Load();
            PurchasedComponents.Load();
            Orders.Load();
        }

        public BDLabsDbContext(DbContextOptions<BDLabsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Component> Components { get; set; } = null!;
        public virtual DbSet<PurchasedComponent> PurchasedComponents { get; set; } = null!; 
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=Company;Integrated Security=True;");
            }
        }
    }
}
