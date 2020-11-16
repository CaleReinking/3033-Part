using _P__MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace _P__MVC.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokemonApi allpokemon;

            using (var client = new HttpClient())
            {
                var funny = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100").Result;
                allpokemon = JsonConvert.DeserializeObject<PokemonApi>(funny);
            }

            return View(allpokemon.results);
        }
    }
}