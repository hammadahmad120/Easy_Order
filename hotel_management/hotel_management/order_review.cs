using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class order_review : Form
    {
        public order_review()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Worder o = new Worder();
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            review r = new review();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            order o=new order();
            o.Show();
        }
    }
}
