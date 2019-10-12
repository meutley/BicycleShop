using System;

namespace BicycleShop.Data.Models.Bike
{
    public class Bike
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid ModelId { get; }
        public BikeModel BikeModel { get; }
        public int StatusId { get; set; }
        public Status Status { get; set; } //= "Prepping";
        public DateTime PurchaseDate { get; } = DateTime.UtcNow;
        public DateTime LastCheckedOutDate { get; set; } = DateTime.UtcNow;
        public DateTime LastReturnedDate { get; set; } = DateTime.UtcNow;
    }
}
