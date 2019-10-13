using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IStatusRepository
    {
        ICollection<Status> GetAll();
        Status GetById(int id);
    }
}