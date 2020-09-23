using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class CollectionList
    {
        [JsonProperty("has_more")]
        public int has_more { get; set; }

        [JsonProperty("share_url")]
        public string share_url { get; set; }

        [JsonProperty("display_text")]
        public string display_text { get; set; }

        [JsonProperty("has_total")]
        public int has_total { get; set; }

        [JsonProperty("user_has_addresses")]
        public bool user_has_addresses { get; set; }

        [JsonProperty("collections")] 
        public CollectionRecord[] collections { get; set; }

    }
}
