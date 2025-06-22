using Microsoft.EntityFrameworkCore;
using MyConcept.Data.Entities;
using MyConcept.Data.Enums;

namespace MyConcept.Data
{
    public class MyConceptContext : DbContext
    {
        public DbSet<BasketEntity> Baskets { get; set; }
        public DbSet<BasketProductEntity> BasketProducts { get; set; }
        public DbSet<WishListEntity> WishLists { get; set; }
        public DbSet<WishListProductEntity> WishListProducts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<GarmentEntity> Garments { get; set; }
        public DbSet<ShoeEntity> Shoes { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<ActualItemEntity> ActualItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyConcept;Username=postgres;Password=admin");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<ActualItemState>();
            modelBuilder.Entity<ShoeEntity>().ToTable("Shoes");
            modelBuilder.Entity<GarmentEntity>().ToTable("Garments");
        }
    }
}
