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
    public partial class Product_card : UserControl
    {
        public Product_card()
        {
            InitializeComponent();
        }
        private String _product;

        public String product
        {
            get { return _product; }
            set { _product = value; label1.Text = value; }
        }

        private String _product1;

        public String product1
        {
            get { return _product1; }
            set { _product1 = value; label2.Text = value; }
        }

        private String _product2;

        public String product2
        {
            get { return _product2; }
            set { _product2 = value; label3.Text = value; }
        }

        private String _product3;

        public String product3
        {
            get { return _product3; }
            set { _product3 = value; label4.Text = value; }
        }

        private String _product4;

        public String product4
        {
            get { return _product4; }
            set { _product4 = value; label5.Text = value; }
        }
        private void Product_card_Load(object sender, EventArgs e)
        {

        }
    }
}
