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
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonAPI pokes;

            int id = 1;
            using (var client = new HttpClient())
            {
                var jsonresult = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon/"+id).Result;
                pokes = JsonConvert.DeserializeObject<PokemonAPI>(jsonresult);
            }

            
            return View(pokes);
        }
    }
}