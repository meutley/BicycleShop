using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class BikeModelRepository : IBikeModelRepository
    {
        private readonly DataContext _context;

        public BikeModelRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<BikeModel> GetAll()
        {
            return _context.BikeModels.ToList();
        }

        public BikeModel GetById(Guid id)
        {
            return _context.BikeModels.SingleOrDefault(b => b.Id == id);
        }

        public void Insert(BikeModel bikeModel)
        {
            _context.BikeModels.Add(bikeModel);
            _context.SaveChanges();
        }

        public void Update(BikeModel bikeModel)
        {
            _context.BikeModels.Update(bikeModel);
            _context.SaveChanges();
        }

        public void Delete(BikeModel bikeModel)
        {
            bikeModel.IsActive = false;
            _context.BikeModels.Update(bikeModel);
            _context.SaveChanges();
        }
    }
}
