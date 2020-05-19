using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Travel_Question
    {
        public int travel_questions_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> travel_questions_from_id { get; set; }
        public string travel_questions_message { get; set; }
        public Nullable<System.DateTime> travel_questions_date { get; set; }
        public string travel_answers_message { get; set; }
        public Nullable<System.DateTime> travel_answers_date { get; set; }
    }
}