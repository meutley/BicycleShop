using System;

namespace BicycleShop.Service.DTOs.Bike
{
    public class BikeDto
    {
        public Guid Id { get; }
        public Guid ModelId { get; }
        public BikeModelDto BikeModel { get; }
        public int StatusId { get; set; }
        public StatusDto Status { get; set; }
        public DateTime PurchaseDate { get; }
        public DateTime LastCheckedOutDate { get; set; }
        public DateTime LastReturnedDate { get; set; }
    }
}
