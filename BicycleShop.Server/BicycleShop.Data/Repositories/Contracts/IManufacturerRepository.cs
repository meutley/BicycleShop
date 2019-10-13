using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IManufacturerRepository
    {
        ICollection<Manufacturer> GetAll();
        Manufacturer GetById(int id);
        void Insert(Manufacturer manufacturer);
    }
}