using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    internal class product
    {

        public int  Customer_ID { get; set; }
        public string OrderDate { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public bool isavail { get; set; }
        public int QTY { get; set; }
        public int Price { get; set; }

        static List<product> products = new List<product>();
    
        public void save()
            {
            products.Add(this);
            }
        public static List<product> getallproduct()
            {
            return products;
            }

        public static List<product> getallproduct(String name)
        {
            List<product> p1 = new List<product>();
            foreach (product p in products)
                p1.Add(p);
            return p1;
        }
    }
}
