using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _P
{
    class Characters
    {
        public class Theory
        {
            public List<Funny> results { get; set; }

        }

        public class Funny
        {
            public string name { get; set; }
            public string url { get; set; }
            public string image { get; set; }
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
            public override string ToString()
            {
                string thise = $"The height is {height}, the weight is {weight}";
                return thise;
            }
        }

    }

}
