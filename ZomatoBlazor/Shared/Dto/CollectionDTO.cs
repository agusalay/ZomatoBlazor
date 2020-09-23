using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class CollectionDTO
    {
        [JsonProperty("collection_id")]
        public int collection_id { get; set; }

        [JsonProperty("res_count")]
        public int res_count { get; set; }

        [JsonProperty("image_url")]
        public string image_url { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("share_url")]
        public string share_url { get; set; }
    }
}
