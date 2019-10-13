using System;

namespace BicycleShop.Service.DTOs.Bike
{
    public class BikeModelDto
    {
        public string ModelName { get; set; }
        public ManufacturerDto ManufacturerId { get; set; }
        public BikeTypeDto BikeType { get; set; }
        public string Description { get; set; }
    }
}