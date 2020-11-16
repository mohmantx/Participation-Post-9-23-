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
        //Author: Matthew Ohman
        // GET: Pokemon
        public ActionResult Pokedex()
        {
            PokemonAPI pokes;

            using (var client = new HttpClient())
            {
                var jsonresult = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100").Result;
                pokes = JsonConvert.DeserializeObject<PokemonAPI>(jsonresult);
            }

            
            return View(pokes.results);
        }

        public ActionResult Info(string id)
        {
            //if (string.IsNullOrEmpty(id))
            //{

            //}

            PokemonInfo information;

            using (var client = new HttpClient())
            {
                var jsonresult = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;
                information = JsonConvert.DeserializeObject<PokemonInfo>(jsonresult);
            }


            return View(information);
        }
    }
}