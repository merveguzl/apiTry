using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class AddController : ApiController
    {
        MadalyonContext dbContext = new MadalyonContext();
        [AcceptVerbs("GET", "POST")]
        public void BookAdd(string incomingBookname, string incomingWritename, string incomingChoise, int incomingUser_id)
        {
                Book_Table newuser = new Book_Table();
                newuser.user_id = incomingUser_id;
                newuser.book_name = incomingBookname;
                newuser.writer_name = incomingWritename;
                newuser.book_choise = incomingChoise;
                dbContext.Book_Table.Add(newuser);
                dbContext.SaveChanges();
        }
        [AcceptVerbs("GET", "POST")]
        public void MapAdd(string incomingCountry, string incomingCity, DateTime date, string incomingChoise, int incomingUser_id)
        {
            Travel_Map_Table newuser = new Travel_Map_Table();
            newuser.travel_date = date;
            newuser.user_id = incomingUser_id;
            newuser.travel_country = incomingCountry;
            newuser.travel_city = incomingCity;
            newuser.travel_choise = incomingChoise;
            dbContext.Travel_Map_Table.Add(newuser);
            dbContext.SaveChanges();
        }

    }
}
