using BicycleShop.Service.DTOs.Bike;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BicycleShop.Service.Services.Bike
{
    public class BikeBasicInfoService
    {
        public ICollection<BikeModelDto> GetAllBikes()
        {
            return new Collection<BikeModelDto>();
        }

        public ICollection<BikeModelDto> GetAllBikesByModel()
        {
            return new Collection<BikeModelDto>();
        }

        public BikeDto GetBikeById(Guid id)
        {
            return new BikeDto();
        }

        /// <summary>
        /// Get information on bikes by the BikeModel id
        /// </summary>
        /// <param name="id">BikeModel ID</param>
        /// <returns>ICollection<BikeDto></returns>
        public ICollection<BikeDto> GetBikesByModelId(Guid id)
        {
            return new Collection<BikeDto>();
        }
    }
}
