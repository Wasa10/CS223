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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        Boolean x = false;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conn_Sql.deleteStudent(int.Parse(textBox1.Text));
                errorProvider1.Clear();

            }
            catch (Exception e1)
            {
                x = true;
                errorProvider1.SetError(textBox1, "Number required");
            }
        }
    }
}
