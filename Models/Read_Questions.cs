using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Read_Questions
    {
        public int read_questions_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> read_questions_from_id { get; set; }
        public string read_questions_message { get; set; }
        public Nullable<System.DateTime> read_questions_date { get; set; }
        public string read_answers_message { get; set; }
        public Nullable<System.DateTime> read_answers_date { get; set; }
    }
}