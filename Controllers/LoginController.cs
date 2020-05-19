using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
using Microsoft.SqlServer.Server;

namespace apiTry.Controllers
{
    
    public class LoginController : ApiController
    {
        MadalyonContext dbContext = new MadalyonContext();
        [AcceptVerbs("GET", "POST")]
        public int SignIn(string incomingUsername, string incomingPassword)
        {
            User_Table control = dbContext.User_Table.Where(u => u.user_nickname == incomingUsername && u.user_password == incomingPassword).FirstOrDefault();
            if (control!=null)
            {
                return control.user_id;
            }
            else
            {
                return (-1);
            }
        }
        [AcceptVerbs("GET","POST")]
        public int SignUp(string incomingUsername, string incomingName, string incomingSurname, string incomingMail, string incomingPassword)
        {
            User_Table controlUsername = dbContext.User_Table.Where(u => u.user_nickname == incomingUsername).FirstOrDefault();
            User_Table controlMail = dbContext.User_Table.Where(u => u.user_email == incomingName).FirstOrDefault();
            if (controlUsername != null)
            {
                return (-1);
            }
            else if(controlMail != null)
            {
                return (-2);
            }
            else
            {
                User_Table newuser = new User_Table();
                newuser.user_nickname = incomingUsername;
                newuser.user_name = incomingName;
                newuser.user_surname = incomingSurname;
                newuser.user_email = incomingMail;
                newuser.user_password = incomingPassword;
                dbContext.User_Table.Add(newuser);
                dbContext.SaveChanges();
                return (newuser.user_id);
            }
        }
            
            
            
            
            
            } 
}
