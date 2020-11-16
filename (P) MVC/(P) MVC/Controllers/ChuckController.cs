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
    public class ChuckController : Controller
    {
        // GET: Chuck
        public ActionResult Index()
        {
            RandomChuckJoke joke;

            using (var client = new HttpClient())
            {
                var funny = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;
                joke = JsonConvert.DeserializeObject<RandomChuckJoke>(funny);
            }
            return View(joke);
        }
    }
}