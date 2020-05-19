using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Travel_Map
    {
        public int Travel_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string travel_choise { get; set; }
        public string travel_city { get; set; }
        public string travel_country { get; set; }
        public Nullable<System.DateTime> travel_date { get; set; }

    }
}