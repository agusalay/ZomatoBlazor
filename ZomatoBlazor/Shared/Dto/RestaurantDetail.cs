using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class RestaurantDetail
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        
        public string average_cost_for_two { get; set; }
        public string price_range { get; set; }
        public string currency { get; set; }
        public string thumb { get; set; }
        public string featured_image { get; set; }
        public string photos_url { get; set; }
        public string menu_url { get; set; }
        public string events_url { get; set; }
        
        public string has_online_delivery { get; set; }
        public string is_delivering_now { get; set; }
        public string has_table_booking { get; set; }
        public string deeplink { get; set; }
        public string cuisines { get; set; }
        public string all_reviews_count { get; set; }
        public string photo_count { get; set; }
        public string phone_numbers { get; set; }      
        public List<AllReview> all_reviews { get; set; }
        public Location location { get; set; }
        public UserRating user_rating { get; set; }
    }
}
