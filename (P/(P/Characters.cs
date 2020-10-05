using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
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
                string done = $"{name}";
                return done;
            }
        }
        public class Loser
        { 
            public string height { get; set; }
            public string weight { get; set; }
            public Sprite sprites { get; set; }
            public override string ToString()
            {
                string thise = $"The height is {height}\n the weight is {weight}\n";
                return thise;
            }
            
        }
        public class Sprite
        {
            public string front_default { get; set; }
            public string back_default { get; set; }
        }
        
    }

}
