using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Kassa
{
    internal class Good
    {
        public string Name { get; set; }

        public int Count { get; set; }

        public double Price { get; set; }

        public Good(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }

        public Good() : this("NoName", 0, 0) { }

    }
}
