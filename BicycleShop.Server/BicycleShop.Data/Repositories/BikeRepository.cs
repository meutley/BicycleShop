using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BicycleShop.Data.Repositories
{
    public class BikeRepository : IBikeRepository
    {
        private DataContext _context;

        public BikeRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Bike>> GetAsync(Expression<Func<Bike, bool>> filter = null)
        {
            var bikes = _context.Bikes as IQueryable<Bike>;
            if (filter != null)
            {
                bikes = bikes.Where(filter);
            }

            return await bikes.ToListAsync();
        }

        public Bike GetById(Guid id)
        {
            return _context.Bikes.SingleOrDefault(b => b.Id == id);
        }

        public void Insert(Bike bike)
        {
            _context.Bikes.Add(bike);
            _context.SaveChanges();
        }

        public void Update(Bike bike)
        {
            _context.Bikes.Update(bike);
            _context.SaveChanges();
        }

        public void Delete(Bike bike)
        {
            bike.IsActive = false;
            _context.Bikes.Update(bike);
            _context.SaveChanges();
        }
    }
}
