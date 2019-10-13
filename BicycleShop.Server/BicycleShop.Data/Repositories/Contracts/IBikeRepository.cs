using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IBikeRepository
    {
        void Delete(Bike bike);
        Task<ICollection<Bike>> GetAsync(Expression<Func<Bike, bool>> filter = null);
        Bike GetById(Guid id);
        void Insert(Bike bike);
        void Update(Bike bike);
    }
}