using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory
{
    
    public partial class Main : Form
    {
        
        public Main()
        {
            
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
            addToolStripMenuItem.Enabled = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }


            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Search s = new Search();
            s.MdiParent = this;
            s.Show();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Display d = new Display();
            d.MdiParent = this;
            d.Show();

        }

       

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            Delete de = new Delete();
            de.MdiParent = this;
            de.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
