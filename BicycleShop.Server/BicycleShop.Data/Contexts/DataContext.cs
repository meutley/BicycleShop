using BicycleShop.Data.EntityMappers;
using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore;

namespace BicycleShop.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeHistoryItem> BikeHistoryItems { get; set; }
        public DbSet<BikeModel> BikeModels { get; set; }
        public DbSet<BikeType> BikeTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<RepairNote> RepairNotes { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
