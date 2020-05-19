using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Experience
    {
        public int experience_id { get; set; }
        public int user_id { get; set; }
        public string experience_name { get; set; }
        public string experience_text { get; set; }
        public string experience_photo { get; set; }
        public string experience_location { get; set; }

    }
}