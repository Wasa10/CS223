using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Regex reg = new Regex(@"^[0-9]+$");
            Regex reg1 = new Regex(@"^[A-Z,a-z]+$");

            if (!reg.IsMatch(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "Number should be greater than three Number");
            }
            else if (!reg.IsMatch(txt_inventorynumber.Text))
            {
                errorProvider1.SetError(txt_inventorynumber, "Invalid Inventory Number");
            }
            else  if (!reg1.IsMatch(txt_objectname.Text))
            {
                errorProvider1.SetError(txt_objectname, "Invalid objectname");
            }
            else if (!reg.IsMatch(txt_count.Text))
            {
                errorProvider1.SetError(txt_count, "Invald Count");

            }
            else if (!reg.IsMatch(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "Price should be greater than three Number");
            }
            else
            {

                product p = new product { Customer_ID = int.Parse(txt_number.Text), OrderDate = dateTimePicker1.Value.ToShortDateString(), Product_ID = int.Parse(txt_inventorynumber.Text), Product_Name = txt_objectname.Text, QTY = int.Parse(txt_count.Text), Price = int.Parse(txt_price.Text) };
                p.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getallproduct();
                
                /*public string ConnectionString = "Data Source=LAPTOP-C4GAEJQU\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string Query = "INSERT INTO Table1 (Customer_ID,OrderDate,Product_ID,Product_Name,QTY,Price) VALUES ( '" + Customer_ID + "' , "'+OrderDate+'",'""+Product_ID+','"+Product_Name+"','"+QTY+"','"+Price+"')";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
               */ MessageBox.Show("Saved succsusfully!");
                
            }
            errorProvider1.Clear();
            
  
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            product p = new product();
            product a = product.findone(textBox1.Text);
            if (a == null)
            {
                MessageBox.Show("product not found");

            }
            else
            {
                MessageBox.Show("Customer ID = " + a.Customer_ID + "\n" + "Date = " + a.OrderDate+ "\n" + "Product ID= " + a.Product_ID + "\n " + "Product Name= " + a.Product_Name + "\n" + "QTY= " + a.QTY + "\n" + "Price = " + a.Price);
            }
        }
    }
    }

