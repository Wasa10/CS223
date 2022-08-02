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

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            product p = new product { Number = double.Parse(txt_number.Text),Date = dateTimePicker1.Value.ToShortDateString(), Inventory_Number = double.Parse(txt_inventorynumber.Text), Object_Name = txt_objectname.Text, Count = double.Parse(txt_count.Text), Price = double.Parse(txt_price.Text) };
            
            Regex reg = new Regex(@"^[0-9]+$");
            Regex reg1 = new Regex(@"^[A-Z,a-z]+$");

            if (!reg.IsMatch(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "Number should be greater than three Number");
            }
            if (!reg.IsMatch(txt_inventorynumber.Text))
            {
                errorProvider1.SetError(txt_inventorynumber, "Invalid Inventory Number");
            }
            if (!reg1.IsMatch(txt_objectname.Text))
            {
                errorProvider1.SetError(txt_objectname, "Invalid objectname");
            }
            if (!reg.IsMatch(txt_count.Text))
            {
                errorProvider1.SetError(txt_count, "Invald Count");

            }
            if (!reg.IsMatch(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "Price should be greater than three Number");
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = product.getallproduct();
                MessageBox.Show("Saved succsusfully!");
                p.save();
            }
            errorProvider1.Clear();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
