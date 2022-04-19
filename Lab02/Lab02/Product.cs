using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }
        static int count = 0;
        public Product()
        {
            count++;
        }
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price; 
            count++;
        }

        public override string ToString()
        {
            return $"Product #{count}\n\tName: {this.name}\n\tPrice: ${this.price}";
        }
    }
}
