using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;

namespace apiTry.Controllers
{
    public class LibraryController : ApiController
    {
        public IEnumerable<Book> Get()
        {
            IEnumerable<Book> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Book_Table> deneme = dbContext.Book_Table.ToList();
                List<Book> aktar = new List<Book>();
                foreach (Book_Table item in deneme)
                {
                    Book t = new Book();
                    t.book_id = item.book_id;
                    t.user_id = item.user_id;
                    t.book_choise = item.book_choise;
                    t.book_name = item.book_name;
                    t.writer_name = item.writer_name;
                    aktar.Add(t);
                }
                model = aktar;
            }
            return model;
        }
    }
}
