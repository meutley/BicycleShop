using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleShop.Data.EntityMappers
{
    public class BikeHistoryItemMap
    {
        public BikeHistoryItemMap(EntityTypeBuilder<BikeHistoryItem> entityBuilder)
        {
            entityBuilder.HasKey(bh => bh.Id);

            entityBuilder.HasOne(bh => bh.Bike)
                         .WithMany(b => b.BikeHistories)
                         .HasForeignKey(bh => bh.BikeId);

            entityBuilder.HasOne(bh => bh.Status)
                         .WithMany()
                         .HasForeignKey(bh => bh.StatusId);
        }
    }
}
