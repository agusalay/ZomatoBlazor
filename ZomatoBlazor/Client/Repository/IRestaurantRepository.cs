using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZomatoBlazor.Shared.Dto;

namespace ZomatoBlazor.Client.Repository
{
    public interface IRestaurantRepository
    {
        Task<RestaurantListDto> GetNearByRestaurants(decimal? lat, decimal? lon , int page, int recordsperpage);
        Task<RestaurantDetail> GetRestaurant(string id);
        Task<RestaurantListDto> GetRestaurants(string cityId, string collection_id);
    }
}
