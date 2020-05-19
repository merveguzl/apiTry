using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class ReviewController : ApiController
    {
        public IEnumerable<Review> Get()
        {
            IEnumerable<Review> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Review_Table> deneme = dbContext.Review_Table.ToList();
                List<Review> aktar = new List<Review>();
                foreach (Review_Table item in deneme)
                {
                    Review t = new Review();
                    t.review_id = item.review_id;
                    t.user_id = item.user_id;
                    t.review_name = item.review_name;
                    t.review_photo = item.review_photo;
                    t.review_text = item.review_text;
                    aktar.Add(t);

                }
                model = aktar;
            }
            return model;
        }
    }
}
