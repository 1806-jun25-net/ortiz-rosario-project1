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

        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizzas> Pizzas { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.IngredientId);

                entity.ToTable("Inventory", "Pizza");

                entity.Property(e => e.IngredientId).HasColumnName("Ingredient_ID");

                entity.Property(e => e.IngredientName)
                    .IsRequired()
                    .HasColumnName("Ingredient_Name")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuantityIngredients).HasColumnName("Quantity_Ingredients");

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventory)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Inventory_to_Store_ID");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("Locations", "Pizza");

                entity.Property(e => e.StoreId)
                    .HasColumnName("Store_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoreLocation)
                    .IsRequired()
                    .HasColumnName("Store_Location")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserIds).HasColumnName("User_IDs");

                entity.HasOne(d => d.UserIdsNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.UserIds)
                    .HasConstraintName("FK_Store_ID");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Orders", "Pizza");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderTime).HasColumnType("datetime");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_ID");

                entity.Property(e => e.ToppingPrice)
                    .HasColumnName("Topping_Price")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasColumnType("decimal(2, 2)");
            });

            modelBuilder.Entity<Pizzas>(entity =>
            {
                entity.HasKey(e => e.PizzaId);

                entity.ToTable("Pizzas", "Pizza");

                entity.Property(e => e.PizzaId).HasColumnName("Pizza_ID");

                entity.Property(e => e.IngredientId).HasColumnName("Ingredient_ID");

                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.PizzaPrice)
                    .HasColumnName("Pizza_Price")
                    .HasColumnType("decimal(2, 2)");

                entity.Property(e => e.PizzaSizes)
                    .IsRequired()
                    .HasColumnName("Pizza_Sizes")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToppingPrice).HasColumnType("decimal(2, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Pizzas)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Pizza_ID_to_Orders");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserIds);

                entity.ToTable("Users", "Pizza");

                entity.Property(e => e.UserIds).HasColumnName("User_IDs");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StoreId).HasColumnName("Store_ID");
            });
        }
    }
}
