using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    internal class Conn_Sql
    {
        static SqlConnection con;

        public static void connection()
        {
            String connectionString = @" Data Source =LAPTOP-C4GAEJQU\SQLEXPRESS;Initial Catalog =Customer;Integrated Security=True;";
            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                MessageBox.Show("Connected");
            }
            catch (SqlException e)
            {
                MessageBox.Show("e.Message");
            }
        }
        public void insertpproduct(product p)
        {
            string insertquery = "insert into Table_1 values('" + p.Customer_ID + "', '" + p.OrderDate + "', '" + p.Product_ID + "', '" + p.Product_Name + "', '" + p.QTY + "', '" + p.Price + "')";
            try
            {
                connection();

                SqlCommand cmd = new SqlCommand(insertquery, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show($"Product {p.Product_Name} has been Added Successfully");
                //con.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void deleteStudent(int Customer_ID)
        {
            string cs = @"server =DESKTOP-0SC7RBT\SQLEXPRESS ;database=product;integrated security= true";

            string query = "delete from Table_1 where Customer_ID =" + Customer_ID;


            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("delete Successfully");
                else
                {
                    MessageBox.Show("Item doesnt exist!");

                }
            }

        }


        public void selectallpproduct(List<product> temp)
        {

            try
            {
                connection();
                SqlCommand cmd = new SqlCommand("select * from Table_1", con);
                SqlDataReader res = cmd.ExecuteReader();
                while (res.Read())
                {
                    product p = new product();
                    p.Customer_ID = int.Parse(res[2].ToString());
                    p.OrderDate = res[3].ToString();
                    p.Product_ID = int.Parse(res[4].ToString());
                    p.Product_Name = res["Product"].ToString();
                    p.QTY = int.Parse(res[6].ToString());
                    p.Price = int.Parse(res[5].ToString());
                    temp.Add(p);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
