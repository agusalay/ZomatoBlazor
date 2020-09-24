using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZomatoBlazor.Client.Helpers;
using ZomatoBlazor.Shared.Dto;

namespace ZomatoBlazor.Client.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly IHttpService httpService;
        private string url = "https://developers.zomato.com/api/v2.1/";
        public RestaurantRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<RestaurantListDto> GetRestaurants(string cityId, string collection_id)
        {
            string param = $"search?entity_id={cityId}&entity_type=city&collection_id={collection_id}&sort=rating&order=asc";

            var response = await httpService.Get<RestaurantListDto>(url+param);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;

        }

        public async Task<RestaurantDetail> GetRestaurant(string id)
        {
            string param = $"restaurant?res_id={id}";

            var response = await httpService.Get<RestaurantDetail>(url + param);

            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }
       
    }
}
