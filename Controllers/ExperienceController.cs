using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class ExperienceController : ApiController
    {
        public IEnumerable<Experience> Get()
        {
            IEnumerable<Experience> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Experience_Table> deneme = dbContext.Experience_Table.ToList();
                List<Experience> aktar = new List<Experience>();
                foreach (Experience_Table item in deneme)
                {
                    Experience t = new Experience();
                    t.experience_id = item.experience_id;
                    t.user_id = item.user_id;
                    t.experience_location = item.experience_location;
                    t.experience_name = item.experience_name;
                    t.experience_photo = item.experience_photo;
                    t.experience_text = item.experience_text;
                    aktar.Add(t);

                }
                model = aktar;
            }
            return model;
        }
    }
}
