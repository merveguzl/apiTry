using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class BookListController : ApiController
    {
        public IEnumerable<Top> Get()
        {
            IEnumerable<Top> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Top_Book> deneme = dbContext.Top_Book.ToList();
                List<Top> aktar = new List<Top>();
                foreach (Top_Book item in deneme)
                {
                    Top t = new Top();
                    t.book_id = item.book_id;
                    t.book_name = item.book_name;
                    t.write_name = item.write_name;
                    aktar.Add(t);

                }
                model = aktar;
            }
            return model;
        }
    }
}
