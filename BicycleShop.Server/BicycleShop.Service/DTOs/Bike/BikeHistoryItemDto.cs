using System;
using System.Collections.Generic;

namespace BicycleShop.Service.DTOs.Bike
{
    public class BikeHistoryItemDto
    {
        public Guid Id { get; set; }
        public Guid BikeId { get; set; }
        public BikeDto Bike { get; set; }
        public int StatusId { get; set; }
        public StatusDto Status { get; set; }
        public ICollection<RepairNoteDto> RepairNotes { get; set; }
    }
}
