using System;

namespace BicycleShop.Data.Models.Bike
{
    public class RepairNote
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid BikeId { get; set; }
        public virtual Bike Bike { get; set; }
    }
}