using System;
using System.Collections.Generic;
using BicycleShop.Data.Models.Bike;

namespace BicycleShop.Data.Repositories.Contracts
{
    public interface IRepairNoteRepository
    {
        ICollection<RepairNote> GetAll();
        RepairNote GetById(Guid id);
        ICollection<RepairNote> GetRepairNotesByBikeId(Guid bikeId);
        void Insert(RepairNote repairNote);
        void Update(RepairNote repairNote);
    }
}