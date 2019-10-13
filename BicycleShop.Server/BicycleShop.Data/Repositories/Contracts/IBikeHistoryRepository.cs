using System;
using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IBikeHistoryRepository
    {
        ICollection<BikeHistoryItem> GetAll();
        ICollection<BikeHistoryItem> GetBikeHistoryItemsByBikeId(Guid bikeId);
        BikeHistoryItem GetById(Guid id);
        void Insert(BikeHistoryItem bikeHistoryItem);
        void Update(BikeHistoryItem bikeHistoryItem);
    }
}