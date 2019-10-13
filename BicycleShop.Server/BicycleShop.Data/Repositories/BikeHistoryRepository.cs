using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class BikeHistoryRepository : IBikeHistoryRepository
    {
        private readonly DataContext _context;

        public BikeHistoryRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<BikeHistoryItem> GetAll()
        {
            return _context.BikeHistoryItems.ToList();
        }

        public BikeHistoryItem GetById(Guid id)
        {
            return _context.BikeHistoryItems.SingleOrDefault(b => b.Id == id);
        }

        public ICollection<BikeHistoryItem> GetBikeHistoryItemsByBikeId(Guid bikeId)
        {
            return _context.BikeHistoryItems
                .Where(bhi => bhi.BikeId == bikeId)
                .ToList();
        }

        public void Insert(BikeHistoryItem bikeHistoryItem)
        {
            _context.BikeHistoryItems.Add(bikeHistoryItem);
            _context.SaveChanges();
        }

        public void Update(BikeHistoryItem bikeHistoryItem)
        {
            _context.BikeHistoryItems.Update(bikeHistoryItem);
            _context.SaveChanges();
        }
    }
}
