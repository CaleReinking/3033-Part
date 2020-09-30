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
        public Funny funny { get; set; }
        public List<Funny> results { get; set; }
    }

    public class Funny
    {
        public string Name { get; set; }
        public string URL { get; set; }
    }

}
