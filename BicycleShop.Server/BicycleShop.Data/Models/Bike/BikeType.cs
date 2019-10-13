using System;
using System.Collections.Generic;

namespace BicycleShop.Data.Models.Bike
{
    public class BikeType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public decimal HourlyPrice { get; set; }
        public decimal DailyPrice { get; set; }
        public virtual ICollection<BikeModel> BikeModels { get; set; }
    }
}