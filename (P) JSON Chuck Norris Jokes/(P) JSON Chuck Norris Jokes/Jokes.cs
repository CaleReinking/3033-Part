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
        public string value { get; set; }
        public override string ToString()
        {
            return value;
        }
    }
}
