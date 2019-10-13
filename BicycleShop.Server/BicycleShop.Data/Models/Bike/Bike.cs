using System;
using System.Collections.Generic;

namespace BicycleShop.Data.Models.Bike
{
    public class Bike
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid ModelId { get; }
        public virtual BikeModel BikeModel { get; }
        public int CurrentStatusId { get; set; }
        public virtual Status CurrentStatus { get; set; } //= "Prepping";
        public virtual ICollection<BikeHistoryItem> BikeHistories { get; set; }
        public virtual ICollection<RepairNote> RepairNotes { get; set; }
        public bool IsActive { get; set; }
        public DateTime PurchaseDate { get; } = DateTime.UtcNow;
        public DateTime LastCheckedOutDate { get; set; } = DateTime.UtcNow;
        public DateTime LastReturnedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastRepairedDate { get; set; } = DateTime.UtcNow;
    }
}
