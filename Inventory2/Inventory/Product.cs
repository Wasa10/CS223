using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class product
        {

        static List<product> products = new List<product>();
            public double Number { get; set; }
            public string Date { get; set; }
            public double Inventory_Number { get; set; }
            public string Object_Name { get; set; }
            public double Count { get; set; }
            public double Price { get; set; }

        public void save()
            {
            products.Add(this);
            }
        public static List<product> getallproduct()
            {
            return products;
            }
        }
}
