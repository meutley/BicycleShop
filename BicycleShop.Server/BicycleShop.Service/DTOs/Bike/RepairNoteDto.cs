using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Service.DTOs.Bike
{
    public class RepairNoteDto
    {
        public Guid Id { get; }
        public string Description { get; set; }
    }
}
