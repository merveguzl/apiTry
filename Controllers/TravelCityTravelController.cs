using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiTry.Models;
namespace apiTry.Controllers
{
    public class TravelCityTravelController : ApiController
    {
        public IEnumerable<Travel_Map> Get()
        {
            IEnumerable<Travel_Map> model;
            using (MadalyonContext dbContext = new MadalyonContext())
            {
                List<Travel_Map_Table> deneme = dbContext.Travel_Map_Table.ToList();
                List<Travel_Map> aktar = new List<Travel_Map>();
                foreach (Travel_Map_Table item in deneme)
                {
                    Travel_Map t = new Travel_Map();
                    t.Travel_id = item.Travel_id;
                    t.user_id = item.user_id;
                    t.travel_date = item.travel_date;
                    t.travel_country = item.travel_country;
                    t.travel_city = item.travel_city;
                    t.travel_choise = item.travel_choise;
                    aktar.Add(t);
                }
                model = aktar;
            }
            return model;
        }
    }
}
