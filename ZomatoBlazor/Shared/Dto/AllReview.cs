using System;
using System.Collections.Generic;
using System.Text;

namespace ZomatoBlazor.Shared.Dto
{
    public class AllReview
    {
        public string rating { get; set; }
        public string review_text { get; set; }
        public string id { get; set; }
        public string rating_color { get; set; }
        public string review_time_friendly { get; set; }
        public string rating_text { get; set; }
        public string timestamp { get; set; }
        public string likes { get; set; }
        //public User2 user { get; set; }
        public string comments_count { get; set; }
    }
}
