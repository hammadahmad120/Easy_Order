using System;
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
    public partial class PBill : Form
    {
        public PBill()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToString();
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    flag = false;
            }
            if (flag && textBox1.Text!=""&&Int32.Parse(textBox1.Text.ToString()) >= Int32.Parse(textBox3.Text.ToString()))
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "insert into cc_order (payment) values ('" + textBox3.Text + "')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con.Open();
                string get_id = "select max(order_id) from cc_order";
                SqlDataAdapter sda = new SqlDataAdapter(get_id, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.Rows[0];
                string st = dt.Rows[0][0].ToString();
                //string st = (dr["order_id"].ToString());
                int id = Convert.ToInt16(st);
                string q = "select product_name,quantity,amount from temp_order";
                SqlDataAdapter sda1 = new SqlDataAdapter(q, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr1 = dt1.Rows[i];
                    string inst = "insert into sales(order_id,product,quantity,S_payment) values ('" + id + "','" + dr1["product_name"] + "','" + dr1["quantity"] + "','" + dr1["amount"] + "')";
                    SqlCommand comm1 = new SqlCommand(inst, con);
                    comm1.ExecuteNonQuery();
                }

                con.Close();
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con1.Open();
                string q1 = "delete from temp_order where table_no='" + textBox4.Text + "'";
                SqlCommand com = new SqlCommand(q1, con1);
                com.ExecuteNonQuery();
                con1.Close();


                SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con2.Open();
                string q2 = "update food_review set order_id='" + id + "' where order_id='" + 0 + "'and table_no='" + textBox4.Text + "'";
                SqlCommand com2 = new SqlCommand(q2, con2);
                com2.ExecuteNonQuery();
                con2.Close();
                int amt = int.Parse(textBox1.Text);
                amt = amt - int.Parse(textBox3.Text);
                textBox5.Text = amt.ToString();
                textBox5.Visible = true;
                label4.Visible = true;

                MessageBox.Show("payment successfully recorded.");
            }
            else
            {
                MessageBox.Show("invalid amount entry");
            }
            //this.Hide();
            //Form1 f = new Form1();
            //f.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

             string str = textBox4.Text.ToString();
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    flag = false;
            }
            if (flag && textBox4.Text!=""&&Int32.Parse(textBox4.Text.ToString()) > 0)
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select product_name,quantity,amount from temp_order where table_no='" + textBox4.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(query, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                int gtotal = 0, tx = 0;

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr1 = dt1.Rows[i];
                    ListViewItem lst = new ListViewItem(dr1["product_name"].ToString());
                    lst.SubItems.Add(dr1["quantity"].ToString());
                    lst.SubItems.Add(dr1["amount"].ToString());
                    listView1.Items.Add(lst);
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    con.Open();
                    string query1 = "select P_stock from products where P_name='" + dr1["product_name"].ToString() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query1, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    string st = dt.Rows[0][0].ToString();
                    //string st = (dr["order_id"].ToString());
                    int stk = Convert.ToInt16(st);
                    stk = stk - int.Parse(dr1["quantity"].ToString());
                    string upt = "update products set P_stock='" + stk + "' where P_name='" + dr1["product_name"].ToString() + "'";
                    SqlCommand com = new SqlCommand(upt, con);
                    com.ExecuteNonQuery();
                    con.Close();

                }
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += int.Parse(lstItem.SubItems[2].Text);
                }
                tx = 16 * (gtotal / 100);
                gtotal = gtotal + tx;
                textBox3.Text = Convert.ToString(gtotal);
                textBox2.Text = Convert.ToString(tx);
                conn.Close();
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                label2.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                button1.Visible = true;
            }
           else
           {
               MessageBox.Show("mention valid table no");
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 p=new Form1();
            p.Show();
        }
    }
}
