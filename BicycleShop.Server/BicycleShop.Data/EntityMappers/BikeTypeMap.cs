using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleShop.Data.EntityMappers
{
    public class BikeTypeMap
    {
        public BikeTypeMap(EntityTypeBuilder<BikeType> entityBuilder)
        {
            entityBuilder.HasKey(bt => bt.Id);

            entityBuilder.Property(bt => bt.TypeName)
                         .IsRequired();

            entityBuilder.Property(bt => bt.HourlyPrice)
                         .IsRequired();

            entityBuilder.Property(bt => bt.DailyPrice)
                         .IsRequired();
        }
    }
}
