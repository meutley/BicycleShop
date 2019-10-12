using System;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeModel
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public Guid BikeTypeId { get; set; }
        public BikeType BikeType { get; set; }
        public string Description { get; set; }
        public bool IsChildBike { get; set; }
    }
}