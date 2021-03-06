﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hotel_management
{
    public partial class sale : Form
    {
        public sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }

        private void sale_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
            con.Open();
            //DateTime dateTime = DateTime.UtcNow.Date;
            string query = "select sales.product,sum(sales.quantity),sum(sales.S_payment) from sales  inner join cc_order on sales.order_id=cc_order.order_id and date='" + DateTime.Now.ToString("M/d/yyyy") + "' group by sales.product ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                ListViewItem lst = new ListViewItem(dt.Rows[i][0].ToString());
                lst.SubItems.Add(dt.Rows[i][1].ToString());
                lst.SubItems.Add(dt.Rows[i][2].ToString());
                listView1.Items.Add(lst);
            }
            int gtotal = 0,tx=0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += int.Parse(lstItem.SubItems[2].Text);
            }
            tx = 16 * (gtotal / 100);
            gtotal = gtotal + tx;
            textBox1.Text = Convert.ToString(gtotal);
            textBox2.Text = Convert.ToString(tx);
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
