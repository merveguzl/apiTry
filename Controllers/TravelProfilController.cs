using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class TravelProfilController : ApiController
    {
        MadalyonContext dbContext = new MadalyonContext();
        [AcceptVerbs("GET", "POST")]
        public string GetName(int incomingID)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            return (control.user_name+" "+control.user_surname);

        }

        [AcceptVerbs("GET", "POST")]
        public string GetPhoto(int incomingID)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            return (control.user_photo);

        }
        public string GetCity(int incomingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == incomingID ).FirstOrDefault();
            return (control.user_info_city);
        }
        [AcceptVerbs("GET","POST")]
        public int GetContactNo(int incomingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            return ((int)control.user_info_contact_no);
        }
        [AcceptVerbs("GET", "POST")]
        public string GetHobby(int incomingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            return (control.user_info_hobby);
        }
        [AcceptVerbs("GET", "POST")]
        public int GetShareCount(int incomingID)
        {
            int control = dbContext.Experience_Table.Where(u => u.user_id == incomingID).Count();
            return (control);
        }
        [AcceptVerbs("GET", "POST")]
        public int GetTravelQuestionsCount(int incomingID)
        {
            int control = dbContext.Travel_Questions_Table.Where(u => u.travel_questions_from_id == incomingID && u.travel_answers_message != null).Count();
            return (control);
        }
        [AcceptVerbs("GET", "POST")]
        public int GetReadQuestionsCount(int incomingID)
        {
            int control = dbContext.Read_Questions_Table.Where(u => u.read_questions_from_id == incomingID&& u.read_answers_message !=null ).Count();
            return (control);
        }
        [AcceptVerbs("GET", "POST")]
        public int GetReliability(int inComingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            return ((int)control.user_info_reliability);
        }
        [AcceptVerbs("GET", "POST")]
        public string GetNickname(int inComingID)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            return (control.user_nickname);
        }
        [AcceptVerbs("GET", "POST")]
        public string GetTravelChoise(int inComingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            return (control.user_info_travel);
        }
        [AcceptVerbs("GET", "POST")]
        public string GetEmail(int inComingID)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            return (control.user_email);
        }
        [AcceptVerbs("GET", "POST")]
        public string GetReadChoise(int inComingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            return (control.user_info_book);
        }
        [AcceptVerbs("GET", "POST")]
        public void GetReliabilityPlus(int inComingID)
        {
            User_Info_Table control = dbContext.User_Info_Table.Where(u => u.user_id == inComingID).FirstOrDefault();
            control.user_info_reliability = + 1 ;
            dbContext.SaveChanges();

        }
    }
}
