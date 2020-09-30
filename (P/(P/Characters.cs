using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _P
{
    class Characters
    {
        public List<Funny> results { get; set; }
    }

    public class Funny
    {
        public string name { get; set; }
        public string url { get; set; }
        public override string ToString()
        {
            string done = $"{name}{url}";
            return done;
        }
    }
    public class Info
    {
        public string height { get; set; }
        public string weight { get; set; }
        public string sprite { get; set; }
    }



}
