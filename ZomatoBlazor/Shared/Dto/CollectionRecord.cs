using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class CollectionRecord
    {
        [JsonProperty("collection")]
        public CollectionDTO collection { get; set; }
    }
}
