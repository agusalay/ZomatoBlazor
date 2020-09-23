using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class RestaurantRecord
    {
        [JsonProperty("restaurant")]
        public Restaurant Restaurant { get; set; }
    }
}
