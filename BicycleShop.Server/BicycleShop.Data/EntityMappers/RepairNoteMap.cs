using BicycleShop.Data.Models.Bike;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Data.EntityMappers
{
    public class RepairNoteMap
    {
        public RepairNoteMap(EntityTypeBuilder<RepairNote> entityBuilder)
        {
            entityBuilder.HasKey(rn => rn.Id);

            entityBuilder.Property(rn => rn.Description)
                         .IsRequired();

            entityBuilder.HasOne(rn => rn.Bike)
                         .WithMany(b => b.RepairNotes)
                         .HasForeignKey(rn => rn.BikeId);
        }
    }
}
