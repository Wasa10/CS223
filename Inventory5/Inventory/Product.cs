using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory
{
    internal class product
    {

        public int Customer_ID { get; set; }
        public string OrderDate { get; set; }
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        public bool isavail { get; set; }
        public int QTY { get; set; }
        public int Price { get; set; }

        public static List<product> p = new List<product>();

        public void save()
        {
            MessageBox.Show(this.Product_Name + " has been added successfully!!");
            p.Add(this);
            Conn_Sql conn_Sql = new Conn_Sql();
            conn_Sql.insertpproduct(this);
        }
        public static List<product> getallproduct()
        {
            Conn_Sql conn_Sql = new Conn_Sql();
            List<product> temp = new List<product>();
            conn_Sql.selectallpproduct(temp);
            return temp;
        }

        public static List<product> getallproduct(String name)
        {
            List<product> p1 = new List<product>();
            foreach (product p in p)
                p1.Add(p);
            return p1;
        }
    }
}
