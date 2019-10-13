using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly DataContext _context;

        public ManufacturerRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Manufacturer> GetAll()
        {
            return _context.Manufacturers.ToList();
        }

        public Manufacturer GetById(int id)
        {
            return _context.Manufacturers.SingleOrDefault(b => b.Id == id);
        }

        public void Insert(Manufacturer manufacturer)
        {
            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }
    }
}
