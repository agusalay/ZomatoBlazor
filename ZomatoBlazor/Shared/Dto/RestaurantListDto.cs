using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class RestaurantListDto
    {
        [JsonProperty("results_found")]
        public int results_found { get; set; }

        [JsonProperty("results_shown")]
        public int results_shown { get; set; }

        [JsonProperty("restaurants")]
        public RestaurantRecord[] Restaurants { get; set; }
    }
}
