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
    public partial class Worder : Form
    {
        public Worder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
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
            
            {
                if (flag&&comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text!=""&&Int32.Parse(textBox1.Text.ToString()) > 0)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string query = "select P_price,P_stock from products where P_name='" + comboBox1.Text + "'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(query, conn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        DataRow dr1 = dt1.Rows[i];
                        string st = (dr1["P_price"].ToString());
                        int t = Convert.ToInt16(st);
                        t = Convert.ToInt16(textBox1.Text) * t;
                        string s = dr1["P_stock"].ToString();
                        int stk=Convert.ToInt16(s);
                        if (stk >= int.Parse(textBox1.Text))
                        {
                            ListViewItem lst = new ListViewItem(comboBox1.Text);
                            lst.SubItems.Add(textBox1.Text);
                            lst.SubItems.Add(t.ToString());
                            listView1.Items.Add(lst);
                            button2.Visible = true;
                           
                        }
                        else
                        {
                           
                            MessageBox.Show("Sorry,food item is short");
                            break;
                        }

                        

                    }


                    comboBox1.Text = "";
                    textBox1.Text = "";
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("invalid entries");
                }
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            listView2.Items.Clear();
            if (comboBox2.Text == "fast food")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select P_name from products where P_category='" + comboBox2.Text + "'";
                string query1 = "select P_name,P_price,P_quantity from products where P_category='" + comboBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //comboBox1.DataSource=dt;
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);

                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    //DataRow dr1 = dt1.Rows[i];
                    //DataRow dr = dt.Rows[i];
                    //comboBox1.Items.Add(dr["P_name"].ToString());
                    //ListViewItem listitem = new ListViewItem(dr1["P_name"].ToString());
                    //listitem.SubItems.Add(dr1["P_price"].ToString());
                    //listitem.SubItems.Add(dr1["P_quantity"].ToString());
                    //listView2.Items.Add(listitem);
                    comboBox1.Items.Add(dt.Rows[i][0].ToString());
                    ListViewItem listitem = new ListViewItem(dt1.Rows[i][0].ToString());
                    listitem.SubItems.Add(dt1.Rows[i][1].ToString());
                    listitem.SubItems.Add(dt1.Rows[i][2].ToString());
                    listView2.Items.Add(listitem);

                }
                conn.Close();

            }
            else if (comboBox2.Text == "pakistani")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select P_name from products where P_category='" + comboBox2.Text + "'";
                string query1 = "select P_name,P_price,P_quantity from products where P_category='" + comboBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                //comboBox1.DataSource = dt;
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr1 = dt1.Rows[i];
                    DataRow dr = dt.Rows[i];
                    comboBox1.Items.Add(dr["P_name"].ToString());
                    ListViewItem listitem = new ListViewItem(dr1["P_name"].ToString());
                    listitem.SubItems.Add(dr1["P_price"].ToString());
                    listitem.SubItems.Add(dr1["P_quantity"].ToString());
                    listView2.Items.Add(listitem);
                }
                conn.Close();
            }
            else if (comboBox2.Text == "chinese")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select P_name from products where P_category='" + comboBox2.Text + "'";
                string query1 = "select P_name,P_price,P_quantity from products where P_category='" + comboBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                //comboBox1.DataSource = dt;
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr1 = dt1.Rows[i];
                    DataRow dr = dt.Rows[i];
                    comboBox1.Items.Add(dr["P_name"].ToString());
                    ListViewItem listitem = new ListViewItem(dr1["P_name"].ToString());
                    listitem.SubItems.Add(dr1["P_price"].ToString());
                    listitem.SubItems.Add(dr1["P_quantity"].ToString());
                    listView2.Items.Add(listitem);
                }
                conn.Close();
            }
            else if (comboBox2.Text == "drinks")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select P_name from products where P_category='" + comboBox2.Text + "'";
                string query1 = "select P_name,P_price,P_quantity from products where P_category='" + comboBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                //comboBox1.DataSource = dt;
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    DataRow dr1 = dt1.Rows[i];
                    DataRow dr = dt.Rows[i];
                    comboBox1.Items.Add(dr["P_name"].ToString());
                    ListViewItem listitem = new ListViewItem(dr1["P_name"].ToString());
                    listitem.SubItems.Add(dr1["P_price"].ToString());
                    listitem.SubItems.Add(dr1["P_quantity"].ToString());
                    listView2.Items.Add(listitem);
                }
                conn.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            order ord = new order();
            ord.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gtotal = 0, tx = 0;
            foreach (ListViewItem lstItem in listView1.Items)
            {
                gtotal += int.Parse(lstItem.SubItems[2].Text);
            }
            tx = 16 * (gtotal / 100);
            gtotal = gtotal + tx;
            textBox3.Text = Convert.ToString(gtotal);
            textBox2.Text = Convert.ToString(tx);
            button4.Visible = true;
            button5.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            
            //button2.Visible = false;
            //textBox2.Visible = false;
            //textBox3.Visible = false;
            //label6.Visible = false;
            //label7.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
            conn.Open();
            foreach (ListViewItem item in listView1.Items)
            {
                string query = "insert into temp_order(product_name,quantity,amount) values('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
            }
            conn.Close();

            //string query = "insert into cc_order (payment) values ('" + textBox3.Text + "')";
            //SqlCommand comm = new SqlCommand(query, conn);
            //comm.ExecuteNonQuery();
            //conn.Close();
            //SqlConnection con = new SqlConnection(@"Data Source=SHEIKH\SQLEXPRESS;Initial Catalog=data1;Integrated Security=True;Pooling=False");
            //con.Open();
            //string get_id = "select max(order_id) from cc_order";
            //SqlDataAdapter sda = new SqlDataAdapter(get_id, con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //DataRow dr = dt.Rows[0];
            //string st = dt.Rows[0][0].ToString();
            ////string st = (dr["order_id"].ToString());
            //int id = Convert.ToInt16(st);
            //string q = "select product_name,quantity from temp_order";
            //SqlDataAdapter sda1 = new SqlDataAdapter(q, con);
            //DataTable dt1 = new DataTable();
            //sda1.Fill(dt1);
            //for (int i = 0; i < dt1.Rows.Count; i++)
            //{
            //    DataRow dr1 = dt1.Rows[i];
            //    string inst = "insert into sales(order_id,product,quantity) values ('" + id + "','" + dr1["product_name"] + "','"+dr1["quantity"]+"')";
            //    SqlCommand comm1 = new SqlCommand(inst, con);
            //    comm1.ExecuteNonQuery();
            //}

            //con.Close();

            this.Hide();
            order_review r = new order_review();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            button2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            

        }

        private void Worder_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
