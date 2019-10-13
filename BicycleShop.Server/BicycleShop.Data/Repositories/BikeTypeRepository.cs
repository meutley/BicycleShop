using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class BikeTypeRepository : IBikeTypeRepository
    {
        private readonly DataContext _context;

        public BikeTypeRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<BikeType> GetAll()
        {
            return _context.BikeTypes.ToList();
        }

        public BikeType GetById(int id)
        {
            return _context.BikeTypes.SingleOrDefault(b => b.Id == id);
        }
    }
}
