using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON_Chuck_Norris_Jokes
{
    class Jokes
    {
        public class Joker
        {
            [JsonProperty("results")]
            public List<Funny> results { get; set; }
        }
        public class Funny
        {
            public string icon_url { get; set; }
            public string id { get; set; }
            public string url { get; set; }
            public string value { get; set; }
            public string categories { get; set; }
            public override string ToString()
            {
                return categories;
            }
        }
    }
}
