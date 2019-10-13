using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleShop.Data.EntityMappers
{
    public class BikeModelMap
    {
        public BikeModelMap(EntityTypeBuilder<BikeModel> entityBuilder)
        {
            entityBuilder.HasKey(bm => bm.Id);

            entityBuilder.Property(bm => bm.ModelName)
                         .IsRequired();

            entityBuilder.Property(bm => bm.Description)
                         .IsRequired();

            entityBuilder.Property(bm => bm.IsChildBike)
                         .IsRequired();

            entityBuilder.Property(bm => bm.IsActive)
                         .IsRequired();

            entityBuilder.HasOne(bm => bm.Manufacturer)
                         .WithMany(m => m.BikeModels)
                         .HasForeignKey(bm => bm.ManufacturerId);

            entityBuilder.HasOne(bm => bm.BikeType)
                         .WithMany(bt => bt.BikeModels)
                         .HasForeignKey(bm => bm.BikeTypeId);
        }
    }
}
