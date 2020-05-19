using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class ReadQuestionsController : ApiController
    {
        public IEnumerable<Read_Questions> Get()
        {
            IEnumerable<Read_Questions> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Read_Questions_Table> deneme = dbContext.Read_Questions_Table.ToList();
                List<Read_Questions> aktar = new List<Read_Questions>();
                foreach (Read_Questions_Table item in deneme)
                {
                    Read_Questions m = new Read_Questions();
                    m.read_questions_id = item.read_questions_id;
                    m.read_questions_message = item.read_questions_message;
                    m.read_questions_from_id = item.read_questions_from_id;
                    m.user_id = item.user_id;
                    m.read_questions_date = item.read_questions_date;
                    m.read_answers_message = item.read_answers_message;
                    m.read_answers_date = item.read_answers_date;
                    aktar.Add(m);

                }
                model = aktar;
            }
            return model;
        }
    }
}
