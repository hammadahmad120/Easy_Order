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
    public partial class select_review : Form
    {
        public select_review()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            report r = new report();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            report1 r = new report1();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager m = new manager();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            bad_review b = new bad_review();
            b.Show();
        }
    }
}
