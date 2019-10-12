using System;
using System.Collections.Generic;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeHistory
    {
        public Guid Id { get; set; }
        public Guid BikeId { get; set; }
        public Bike Bike { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public ICollection<RepairNote> RepairNotes { get; set; }
    }
}
