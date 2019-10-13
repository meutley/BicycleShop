using System;
using System.Collections.Generic;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeHistoryItem
    {
        public Guid Id { get; set; }
        public Guid BikeId { get; set; }
        public virtual Bike Bike { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<RepairNote> RepairNotes { get; set; }
    }
}
