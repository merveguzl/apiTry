using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class UpdateController : ApiController
    {
        MadalyonContext dbContext = new MadalyonContext();
        [AcceptVerbs("GET", "POST")]
        public void UpdateHesap(int incomingID, string incomingnickname, string incomingpassword)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            control.user_nickname = incomingnickname;
            control.user_password = incomingpassword;
            dbContext.SaveChanges();
        }
        [AcceptVerbs("GET", "POST")]
        public void UpdateBilgiler(int incomingID, string incomingname, string incomingcity, string incomingtravelchoise, string incominghobby,string incomingreadchoise)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_id == incomingID).FirstOrDefault();
            control.user_name = incomingname;
            User_Info_Table control1 = dbContext.User_Info_Table.Where(i => i.user_id == incomingID).FirstOrDefault();
            control1.user_info_city = incomingcity;
            control1.user_info_travel = incomingtravelchoise;
            control1.user_info_hobby = incominghobby;
            control1.user_info_book = incomingreadchoise;
            dbContext.SaveChanges();
        }
        
    }
}
