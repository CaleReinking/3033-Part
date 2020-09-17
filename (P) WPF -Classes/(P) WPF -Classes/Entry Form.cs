using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace _P__WPF__Classes
{
    class Entry_Form
    {
       public string Address { get; set; }
       public string Name { get; set;  }
       public int ZipCode { get; set; }

            public Entry_Form()
             {

            }
        public Entry_Form(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            zipcode = Convert.ToInt32(ZipCode);
            
        }
        public override string ToString()
        {
            string output = $"{Name} at the address {Address} {ZipCode}"; 
            return output;
        }
        
        
    }
}
