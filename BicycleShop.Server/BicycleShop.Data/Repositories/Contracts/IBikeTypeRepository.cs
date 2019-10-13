using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IBikeTypeRepository
    {
        ICollection<BikeType> GetAll();
        BikeType GetById(int id);
    }
}