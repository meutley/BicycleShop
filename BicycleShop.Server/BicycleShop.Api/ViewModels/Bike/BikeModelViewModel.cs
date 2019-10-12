using BicycleShop.Service.DTOs.Bike;
using System;

namespace BicycleShop.Api.ViewModels.Bike
{
    public class BikeModelViewModel
    {
        public Guid Id { get; set; }
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public Guid BikeTypeId { get; set; }
        public BikeTypeDto BikeType { get; set; }
        public string Description { get; set; }
    }
}