﻿using BicycleShop.Service.DTOs.Bike;
using System;

namespace BicycleShop.Api.ViewModels.Bike
{
    public class BikeViewModel
    {
        public Guid Id { get; }
        public Guid ModelId { get; }
        public BikeModelViewModel BikeModel { get; }
        public int StatusId { get; set; }
        public StatusDto Status { get; set; }
        public DateTime PurchaseDate { get; }
        public DateTime LastCheckedOutDate { get; set; }
        public DateTime LastReturnedDate { get; set; }
    }
}
