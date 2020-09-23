using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZomatoBlazor.Shared.Dto;

namespace ZomatoBlazor.Client.Repository
{
    public interface IRestaurantRepository
    {
        Task<RestaurantListDto> GetRestaurants(string cityId, string collection_id);
    }
}
