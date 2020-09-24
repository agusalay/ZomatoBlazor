using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class UserRating
    {
        [JsonProperty("aggregate_rating")]
        public string aggregate_rating { get; set; }

        [JsonProperty("rating_text")]
        public string rating_text { get; set; }

        [JsonProperty("rating_color")]
        public string rating_color { get; set; }

        [JsonProperty("votes")]
        public decimal votes { get; set; }
    }
}
