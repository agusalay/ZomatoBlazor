using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class AllReview
    {
        [JsonProperty("rating")]
        public decimal rating { get; set; }

        [JsonProperty("review_text")]
        public string review_text { get; set; }

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("rating_color")]
        public string rating_color { get; set; }

        [JsonProperty("review_time_friendly")]
        public string review_time_friendly { get; set; }

        [JsonProperty("rating_text")]
        public string rating_text { get; set; }

        [JsonProperty("timestamp")]
        public string timestamp { get; set; }

        [JsonProperty("likes")]
        public decimal likes { get; set; }
        //public User2 user { get; set; }

        [JsonProperty("comments_count")]
        public decimal comments_count { get; set; }
    }
}
