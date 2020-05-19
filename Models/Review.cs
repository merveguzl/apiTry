using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Review
    {
        public int review_id { get; set; }
        public int user_id { get; set; }
        public string review_name { get; set; }
        public string review_text { get; set; }
        public string review_photo { get; set; }

    }
}