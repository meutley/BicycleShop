using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly DataContext _context;

        public StatusRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Status> GetAll()
        {
            return _context.Statuses.ToList();
        }

        public Status GetById(int id)
        {
            return _context.Statuses.SingleOrDefault(b => b.Id == id);
        }
    }
}
