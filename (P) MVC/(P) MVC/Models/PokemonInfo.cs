using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P__MVC.Models
{
    public class PokemonInfo
    {
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        public Sprite sprites { get; set; }

        public PokemonInfo()
        {
            sprites = new Sprite();
        }

    }

    public class Sprite
    {
        public string front_default { get; set; }
        public string back_default { get; set; }


    }


}