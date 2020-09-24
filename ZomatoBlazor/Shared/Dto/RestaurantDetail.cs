using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class RestaurantDetail
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("timings")]
        public string timings { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("average_cost_for_two")]
        public decimal average_cost_for_two { get; set; }

        [JsonProperty("price_range")]
        public decimal price_range { get; set; }

        [JsonProperty("currency")]
        public string currency { get; set; }

        [JsonProperty("thumb")]
        public string thumb { get; set; }

        [JsonProperty("featured_image")]
        public string featured_image { get; set; }

        [JsonProperty("photos_url")]
        public string photos_url { get; set; }

        [JsonProperty("menu_url")]
        public string menu_url { get; set; }

        [JsonProperty("events_url")]
        public string events_url { get; set; }

        [JsonProperty("has_online_delivery")]
        public int has_online_delivery { get; set; }

        [JsonProperty("is_delivering_now")]
        public int is_delivering_now { get; set; }

        [JsonProperty("has_table_booking")]
        public int has_table_booking { get; set; }

        [JsonProperty("deeplink")]
        public string deeplink { get; set; }

        [JsonProperty("cuisines")]
        public string cuisines { get; set; }

        [JsonProperty("all_reviews_count")]
        public decimal all_reviews_count { get; set; }

        [JsonProperty("photo_count")]
        public decimal photo_count { get; set; }

        [JsonProperty("phone_numbers")]
        public string phone_numbers { get; set; }

        //[JsonProperty("all_reviews")]
        //public List<AllReview> all_reviews { get; set; }

        [JsonProperty("location")]
        public Location location { get; set; }

        [JsonProperty("user_rating")]
        public UserRating user_rating { get; set; }

    
    }
}
