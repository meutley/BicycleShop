using System;
using System.Collections.Generic;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeModel
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public int BikeTypeId { get; set; }
        public virtual BikeType BikeType { get; set; }
        public string Description { get; set; }
        public bool IsChildBike { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Bike> Bikes { get; set; }
    }
}