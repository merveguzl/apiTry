using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class QuestionsSetController : ApiController
    {
        MadalyonContext dbContext = new MadalyonContext();
        [AcceptVerbs("GET", "POST")]
        public void UpdateAnswers(int incomingQuestionsID, string answermessage)
        {
            Travel_Questions_Table controlquestion = dbContext.Travel_Questions_Table.Where(u => u.travel_questions_id == incomingQuestionsID).FirstOrDefault();
            controlquestion.travel_answers_message = answermessage;
            dbContext.SaveChanges();      
        
        }
    }
}
