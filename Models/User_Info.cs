using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class User_Info
    {
        public int user_info_id { get; set; }
        public int user_id { get; set; }
        public Nullable<int> user_info_contact_no { get; set; }
        public string user_info_contact_email { get; set; }
        public string user_info_hobby { get; set; }
        public string user_info_travel { get; set; }
        public Nullable<System.DateTime> user_info_date { get; set; }
        public string user_info_book { get; set; }
        public Nullable<int> user_info_reliability { get; set; }
        public string user_info_city { get; set; }

    }
}