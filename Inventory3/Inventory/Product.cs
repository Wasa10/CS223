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
        public int  Customer_ID { get; set; }
        public string OrderDate { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public int QTY { get; set; }
        public int Price { get; set; }
        public static product findone(string product_name)
        {
            return products.Find(p => p.Product_Name == product_name);
        }
        public static List<product> findall(int price)
        {
            return products.FindAll(p => p.Price == price);
        }
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
