using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BicycleShop.Data.EntityMappers
{
    public class ManufacturerMap
    {
        public ManufacturerMap(EntityTypeBuilder<Manufacturer> entityBuilder)
        {
            entityBuilder.HasKey(m => m.Id);
            entityBuilder.Property(m => m.ImageUrl);
            entityBuilder.Property(m => m.Name)
                         .IsRequired();
        }
    }
}
