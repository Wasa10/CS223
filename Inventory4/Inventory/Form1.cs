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
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Inventory
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        product p = new product();
        private void button1_Click(object sender, EventArgs e)
        {


            if (chk_avail.Checked)
            {
                MessageBox.Show("Item is available");
                p.isavail = chk_avail.Checked;
            }
            else
            {
                MessageBox.Show("Item is not available");
            }

            Boolean x = false;

            try
            {

                p.Customer_ID = int.Parse(txt_number.Text);
                errorProvider1.Clear();

            }
            catch (Exception e1)
            {
                x = true;
                errorProvider1.SetError(txt_number, "Number required");
            }
            //

            try
            {
                errorProvider2.Clear();
                p.Product_ID = int.Parse(txt_inventorynumber.Text);

            }
            catch (Exception e2)
            {

                x = true;
                errorProvider2.SetError(txt_inventorynumber, "Inventory required");
            }
            //

            Regex regex1 = new Regex(@"^[0-9]+$");
            if (regex1.IsMatch(txt_count.Text))
            {
                p.QTY = int.Parse(txt_count.Text);

            }
            else
            {
                errorProvider1.SetError(txt_count, "Invalid count number");
                x = true;
            }
            if (regex1.IsMatch(txt_price.Text))
            {
                p.Price = int.Parse(txt_price.Text);


            }
            else
            {
                errorProvider1.SetError(txt_price, "Invalid price number");
                x = true;
            }


            p.Product_Name = txt_objectname.Text;
            if (string.IsNullOrEmpty(txt_objectname.Text))
            {
                errorProvider1.SetError(txt_objectname, "Object name is required");
            }
            else
            {

                product p = new product { Customer_ID = int.Parse(txt_number.Text), OrderDate = dateTimePicker1.Value.ToShortDateString(), Product_ID = int.Parse(txt_inventorynumber.Text), Product_Name = txt_objectname.Text, QTY = int.Parse(txt_count.Text), Price = int.Parse(txt_price.Text) };
                p.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getallproduct();
                MessageBox.Show("Saved succsusfully!");
                errorProvider1.Clear();

                
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
     
    }
}

