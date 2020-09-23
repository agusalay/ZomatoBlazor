using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZomatoBlazor.Client.Helpers;
using ZomatoBlazor.Shared.Dto;

namespace ZomatoBlazor.Client.Repository
{
    public class CollectionRepository : ICollectionRepository
    {
        private readonly IHttpService httpService;
        private string url = "https://developers.zomato.com/api/v2.1/collections?city_id=";

        public CollectionRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<CollectionList> GetCollection(string cityId)
        {
            var response = await httpService.Get<CollectionList>(url+cityId);

            if(!response.Success)
            {
                throw new ApplicationException( await response.GetBody());
            }

            return response.Response;

        }
    }
}
