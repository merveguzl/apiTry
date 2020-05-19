using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class TravelQuestionController : ApiController
    {
        public IEnumerable<Travel_Question> Get()
        {
            IEnumerable<Travel_Question> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Travel_Questions_Table> deneme = dbContext.Travel_Questions_Table.ToList();
                List<Travel_Question> aktar = new List<Travel_Question>();
                foreach (Travel_Questions_Table item in deneme)
                {
                    Travel_Question m = new Travel_Question();
                    m.travel_questions_id = item.travel_questions_id;
                    m.travel_questions_from_id = item.travel_questions_from_id;
                    m.travel_questions_message = item.travel_questions_message;
                    m.user_id = item.user_id;
                    m.travel_questions_date = item.travel_questions_date;
                    m.travel_answers_date = item.travel_answers_date;
                    m.travel_answers_message = item.travel_answers_message;
                    aktar.Add(m);

                }
                model = aktar;
            }
            return model;
        }
    }
}
