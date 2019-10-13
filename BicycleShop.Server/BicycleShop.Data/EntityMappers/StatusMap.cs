using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Data.EntityMappers
{
    public class StatusMap
    {
        public StatusMap(EntityTypeBuilder<Status> entityBuilder)
        {
            entityBuilder.HasKey(s => s.Id);
            entityBuilder.Property(s => s.Description)
                         .IsRequired();
        }
    }
}
