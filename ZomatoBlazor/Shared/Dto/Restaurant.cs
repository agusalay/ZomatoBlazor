using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class Restaurant
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("cuisines")]
        public string Cuisines { get; set; }

        [JsonProperty("average_cost_for_two")]
        public int AverageCostForTwo { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("featured_image")]
        public string featured_image { get; set; }
    }
}
