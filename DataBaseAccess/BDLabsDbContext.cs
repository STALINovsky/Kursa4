using System;
using System.Collections.Generic;
using Kursa4;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Model;

namespace DataBaseAccess
{
    public partial class BDLabsDbContext : DbContext
    {
        public BDLabsDbContext()
        {
        }

        public BDLabsDbContext(DbContextOptions<BDLabsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CompanyView> CompanyViews { get; set; } = null!;
        public virtual DbSet<Component> Components { get; set; } = null!;
        public virtual DbSet<ComponentsAudit> ComponentsAudits { get; set; } = null!;
        public virtual DbSet<ComponentsComponentsLog> ComponentsComponentsLogs { get; set; } = null!;
        public virtual DbSet<ComponentsLog> ComponentsLogs { get; set; } = null!;
        public virtual DbSet<ComponentsLogsAudit> ComponentsLogsAudits { get; set; } = null!;
        public virtual DbSet<ComponentsView> ComponentsViews { get; set; } = null!;
        public virtual DbSet<Delivery> Deliveries { get; set; } = null!;
        public virtual DbSet<DeliveryView> DeliveryViews { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-PRRSSOA;Initial Catalog=company;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CompanyView");

                entity.Property(e => e.ComponentName).HasMaxLength(50);

                entity.Property(e => e.ComponentsPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");

                entity.Property(e => e.DeliveryName).HasMaxLength(50);

                entity.Property(e => e.ManufacturerName).HasMaxLength(50);

                entity.Property(e => e.ProviderDescription).HasMaxLength(100);

                entity.Property(e => e.ProviderName).HasMaxLength(40);
            });

            modelBuilder.Entity<Component>(entity =>
            {
                entity.HasIndex(e => e.ComponentName, "UQ__Componen__DB06D1C19A327A6A")
                    .IsUnique();

                entity.Property(e => e.ComponentName).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.Components)
                    .HasForeignKey(d => d.ManufacturerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Goods_Manufacturers");
            });

            modelBuilder.Entity<ComponentsAudit>(entity =>
            {
                entity.ToTable("ComponentsAudit");

                entity.Property(e => e.ComponentNameOld)
                    .HasMaxLength(50)
                    .HasColumnName("ComponentName_old");

                entity.Property(e => e.ComponentsAuditDate).HasColumnType("datetime");

                entity.Property(e => e.ComponentsNameNew)
                    .HasMaxLength(50)
                    .HasColumnName("ComponentsName_new");

                entity.Property(e => e.CountNew).HasColumnName("Count_new");

                entity.Property(e => e.CountOld).HasColumnName("Count_old");

                entity.Property(e => e.IsDeletedNew).HasColumnName("IsDeleted_new");

                entity.Property(e => e.IsDeletedOld).HasColumnName("IsDeleted_old");

                entity.Property(e => e.ManufactureIdNew).HasColumnName("ManufactureId_new");

                entity.Property(e => e.ManufactureIdOld).HasColumnName("ManufactureId_old");

                entity.Property(e => e.PriceNew)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Price_new");

                entity.Property(e => e.PriceOld)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Price_old");
            });

            modelBuilder.Entity<ComponentsComponentsLog>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.Component)
                    .WithMany()
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComponentsComponentsLogs_Components");

                entity.HasOne(d => d.ComponentsLog)
                    .WithMany()
                    .HasForeignKey(d => d.ComponentsLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ComponentsComponentsLogs_ComponentsLogs");
            });

            modelBuilder.Entity<ComponentsLog>(entity =>
            {
                entity.Property(e => e.DateOfRegistration).HasColumnType("datetime");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.ComponentsLogs)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("FK_ComponentsLogs_Components");

                entity.HasOne(d => d.Delivery)
                    .WithMany(p => p.ComponentsLogs)
                    .HasForeignKey(d => d.DeliveryId)
                    .HasConstraintName("FK_ComponentsLogs_Delivery");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ComponentsLogs)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_ComponentsLogs_Provider");
            });

            modelBuilder.Entity<ComponentsLogsAudit>(entity =>
            {
                entity.ToTable("ComponentsLogsAudit");

                entity.Property(e => e.ComponentIdNew).HasColumnName("ComponentId_new");

                entity.Property(e => e.ComponentIdOld).HasColumnName("ComponentId_old");

                entity.Property(e => e.ComponentsAuditDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfRegistrationNew)
                    .HasColumnType("datetime")
                    .HasColumnName("DateOfRegistration_new");

                entity.Property(e => e.DateOfRegistrationOld)
                    .HasColumnType("datetime")
                    .HasColumnName("DateOfRegistration_old");

                entity.Property(e => e.DeliveryIdNew).HasColumnName("DeliveryId_new");

                entity.Property(e => e.DeliveryIdOld).HasColumnName("DeliveryId_old");

                entity.Property(e => e.ProviderIdNew).HasColumnName("ProviderId_new");

                entity.Property(e => e.ProviderIdOld).HasColumnName("ProviderId_old");
            });

            modelBuilder.Entity<ComponentsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComponentsView");

                entity.Property(e => e.ComponentName).HasMaxLength(50);

                entity.Property(e => e.ManufacturerName).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.ToTable("Delivery");

                entity.HasIndex(e => e.DeliveryName, "UQ__Delivery__07CC5A851FF54C12")
                    .IsUnique();

                entity.Property(e => e.DeliveryName).HasMaxLength(50);
            });

            modelBuilder.Entity<DeliveryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeliveryView");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasIndex(e => e.ManufacturerName, "UQ__Manufact__3B9CDE2ED398B59F")
                    .IsUnique();

                entity.Property(e => e.ManufacturerName).HasMaxLength(50);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasIndex(e => e.ProviderName, "UQ__Provider__7D057CE54538BE5B")
                    .IsUnique();

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ProviderName).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
