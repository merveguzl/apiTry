using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;

namespace apiTry.Controllers
{
    public class User_TableController : ApiController
    {

        public IEnumerable<User> Get()
        {
            IEnumerable<User> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<User_Table> deneme = dbContext.User_Table.ToList();
                List<User> aktar = new List<User>();
                foreach (User_Table item in deneme)
                {
                    User m = new User();
                    m.user_id = item.user_id;
                    m.user_email = item.user_email;
                    m.user_name = item.user_name;
                    m.user_nickname = item.user_nickname;
                    m.user_password = item.user_password;
                    m.user_photo = item.user_photo;
                    m.user_surname = item.user_surname;
                    aktar.Add(m);

                }
                model = aktar;
            }
            return model;
        }
    }
}
