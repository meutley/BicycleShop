using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleShop.Data.EntityMappers
{
    public class BikeMap
    {
        public BikeMap(EntityTypeBuilder<Bike> entityBuilder)
        {
            entityBuilder.HasKey(b => b.Id);

            entityBuilder.Property(b => b.LastCheckedOutDate)
                         .IsRequired();

            entityBuilder.Property(b => b.LastReturnedDate)
                         .IsRequired();

            entityBuilder.Property(b => b.PurchaseDate)
                         .IsRequired();

            entityBuilder.Property(b => b.IsActive)
                         .IsRequired();

            entityBuilder.HasOne(b => b.BikeModel)
                         .WithMany(bm => bm.Bikes)
                         .HasForeignKey(b => b.ModelId);

            entityBuilder.HasOne(b => b.CurrentStatus)
                         .WithMany()
                         .HasForeignKey(b => b.CurrentStatusId);
        }
    }
}
