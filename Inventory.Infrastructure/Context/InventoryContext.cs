using Inventory.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Context
{
    public class InventoryContext : IdentityDbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { }

        public DbSet<AddressingsInventory> AddressingsInventory { get; set; }
        public DbSet<Inventories> Inventories { get; set; }
        public DbSet<StockCounting> StockCountings { get; set; }
        public DbSet<PerishableItemCounting> PerishableItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Inventories>()
                        .HasMany(s => s.Addressings)
                        .WithOne(s => s.InventoryStart)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AddressingsInventory>()
                        .HasMany(s => s.StockTaking)
                        .WithOne(s => s.AddressingsInventory)
                        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<StockCounting>()
                        .HasMany(s => s.PerishableItem)
                        .WithOne(s => s.StockTaking)
                        .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
