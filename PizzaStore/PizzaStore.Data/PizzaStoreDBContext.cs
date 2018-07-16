using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaStore.Data
{
    public partial class PizzaStoreDBContext : DbContext
    {
        public PizzaStoreDBContext()
        {
        }

        public PizzaStoreDBContext(DbContextOptions<PizzaStoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<PizzasTypes> PizzasTypes { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:ortiz-rosario-1806.database.windows.net,1433;Initial Catalog=PizzaStoreDB;Persist Security Info=False;User ID=ortiz-rosario;Password=Jesuscr1sto;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("Locations", "Pizza");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.StoreLocation)
                    .IsRequired()
                    .HasColumnName("Store_Location")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserIds).HasColumnName("User_Ids");

                entity.HasOne(d => d.UserIdsNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.UserIds)
                    .HasConstraintName("FK__Locations__User___6477ECF3");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Orders", "Pizza");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.OrderTimeStamp)
                    .HasColumnName("Order_TimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.UserIds).HasColumnName("User_Ids");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Orders__Store_ID__68487DD7");

                entity.HasOne(d => d.UserIdsNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserIds)
                    .HasConstraintName("FK__Orders__User_Ids__6754599E");
            });

            modelBuilder.Entity<PizzasTypes>(entity =>
            {
                entity.HasKey(e => e.PizzaId);

                entity.ToTable("PizzasTypes", "Pizza");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_ID");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.PizzaName)
                    .IsRequired()
                    .HasColumnName("Pizza_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PizzaSizes)
                    .IsRequired()
                    .HasColumnName("Pizza_Sizes")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PizzasQuantity).HasColumnName("Pizzas_Quantity");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PizzasTypes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__PizzasTyp__Order__6FE99F9F");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserIds);

                entity.ToTable("Users", "Pizza");

                entity.Property(e => e.UserIds).HasColumnName("User_Ids");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            });
        }
    }
}
