using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class User
    {

        public int user_id { get; set; }
        public string user_nickname { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string user_email { get; set; }
        public string user_photo { get; set; }
        public string user_password { get; set; }
    }
}