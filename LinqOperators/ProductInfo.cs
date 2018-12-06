using System;
using System.Collections.Generic;
using System.Text;

namespace LinqOperators
{
    class ProductInfo
    {
        public ProductInfo(string name, string description, int stock, int make)
        {
            Name = name;
            Description = description;
            Stock = stock;
            Make = make;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public int Make { get; set; }

        public override string ToString()
        {
            return "Product Name : " + Name + " Description : " + Description + " Stock: " + Stock + " Make : " + Make;
        }
    }
}
