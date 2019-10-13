using System;
using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IBikeModelRepository
    {
        void Delete(BikeModel bikeModel);
        ICollection<BikeModel> GetAll();
        BikeModel GetById(Guid id);
        void Insert(BikeModel bikeModel);
        void Update(BikeModel bikeModel);
    }
}