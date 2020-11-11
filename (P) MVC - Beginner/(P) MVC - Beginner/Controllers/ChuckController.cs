using System;
using _P__MVC___Beginner.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web.Mvc;

namespace _P__MVC___Beginner.Controllers
{
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            ChuckAPI chuck;
            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;
                chuck = JsonConvert.DeserializeObject<ChuckAPI>(json);
            }

            return View(chuck);
        }

        //chuck/categories
        //public ActionResult Categories()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var json = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;
        //        chuck = JsonConvert.DeserializeObject<ChuckAPI>(json);
        //    }
        //}
    }
}