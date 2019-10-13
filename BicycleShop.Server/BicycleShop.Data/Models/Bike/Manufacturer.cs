using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleShop.Data.Models.Bike
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BikeModel> BikeModels { get; set; }
    }
}
