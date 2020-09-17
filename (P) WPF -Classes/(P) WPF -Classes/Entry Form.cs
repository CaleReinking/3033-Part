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
        string Address { get; set; }
        string Name { get; set;  }
        string ZipCode { get; set; }

            public Entry_Form()
             {

            }
        public Entry_Form(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            zipcode = Convert.ToInt32(ZipCode);
            
        }
        public override string ToString(string name, string address, int zipcode)
        {
            string output = $"{name} at the address {Address} {ZipCode}"; 
            return output;
        }
        
        
    }
}
