using System;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; }
        public decimal HourlyPrice { get; set; }
        public decimal DailyPrice { get; set; }
    }
}