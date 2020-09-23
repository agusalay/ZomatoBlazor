using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class RestaurantListDto
    {
        [JsonProperty("results_found")]
        public int ResultsFound { get; set; }

        [JsonProperty("results_shown")]
        public int ResultsShown { get; set; }

        [JsonProperty("restaurants")]
        public RestaurantRecord[] Restaurants { get; set; }
    }
}
