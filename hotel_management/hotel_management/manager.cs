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
    public partial class manager : Form
    {
        public manager()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            item t = new item();
            t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //price p = new price();
            //p.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delitem d = new Delitem();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            select_sale m = new select_sale();
            m.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            select_review r = new select_review();
            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            food_list f = new food_list();
            f.Show();
        }

        private void manager_Load(object sender, EventArgs e)
        {

        }
    }
}
