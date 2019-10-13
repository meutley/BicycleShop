using BicycleShop.Data.Contexts;
using BicycleShop.Data.Models.Bike;
using BicycleShop.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BicycleShop.Data.Repositories
{
    public class RepairNoteRepository : IRepairNoteRepository
    {
        private readonly DataContext _context;

        public RepairNoteRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<RepairNote> GetAll()
        {
            return _context.RepairNotes.ToList();
        }

        public RepairNote GetById(Guid id)
        {
            return _context.RepairNotes.SingleOrDefault(b => b.Id == id);
        }

        public ICollection<RepairNote> GetRepairNotesByBikeId(Guid bikeId)
        {
            return _context.RepairNotes
                .Where(rn => rn.BikeId == bikeId)
                .ToList();
        }

        public void Insert(RepairNote repairNote)
        {
            _context.RepairNotes.Add(repairNote);
            _context.SaveChanges();
        }

        public void Update(RepairNote repairNote)
        {
            _context.RepairNotes.Update(repairNote);
            _context.SaveChanges();
        }
    }
}
