using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__P__WPF__Classes_2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }

        public Toy()
        {

        }
        public Toy(string name, string manufacturer, double price)
        {
            Manufacturer = manufacturer;
            Name = name;
            Price = Convert.ToDouble(price);

        }
        public override string ToString()
        {
            string output = $"{Manufacturer}- {Name}";
            return output;
        }
        public string GetAisle()
        {
            return $"{Manufacturer[0]}: - {Price}";
        }
    }
}
