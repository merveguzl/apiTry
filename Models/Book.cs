using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiTry.Models
{
    public class Book
    {
        public int book_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string book_choise { get; set; }
        public string book_name { get; set; }
        public string writer_name { get; set; }

    }
}