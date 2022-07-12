using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            product p = new product { number = double.Parse(txt_number.Text), inventory_number = double.Parse(txt_inventorynumber.Text), object_name = txt_objectname.Text, count = double.Parse(txt_count.Text), price = double.Parse(txt_price.Text) };
            p.save();
            MessageBox.Show("Saved succsusfully!");
        }
    }
}
