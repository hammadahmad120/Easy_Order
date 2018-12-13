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
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text.ToString();

            bool flag1 = true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] < '0' || str1[i] > '9')
                    flag1 = false;
            }
            string str2 = textBox6.Text.ToString();

            bool flag = true;
            int j = 0;
            while(j<str2.Length)
            {
                if (str2[j] < '0' || str1[j] > '9')
                    flag1 = false;
                j++;

            }
            


            if (flag1 && flag && textBox1.Text != "" && textBox4.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox6.Text != "" && Int32.Parse(textBox2.Text.ToString()) > 0 && Int32.Parse(textBox6.Text.ToString()) > 10)
            {



                SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                co.Open();
                string q1 = "select P_name from products where P_name='" + textBox1.Text + "'";
                SqlCommand c = new SqlCommand(q1, co);
                SqlDataReader rd = c.ExecuteReader();
                if (rd.HasRows != true)
                {
                    co.Close();
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    con.Open();
                    string q = "delete from products where P_name='" + textBox5.Text + "'";
                    SqlCommand com = new SqlCommand(q, con);
                    com.ExecuteNonQuery();
                    con.Close();



                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string query = "insert into products values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "')";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show(" item successfully updated");
                    this.Hide();
                    manager_window m = new manager_window();
                    m.Show();
                    conn.Close();
                    //SqlConnection con5 = new SqlConnection(@"Data Source=SHEIKH\SQLEXPRESS;Initial Catalog=data1;Integrated Security=True;Pooling=False");
                    //con5.Open();
                    //string q5 = "delete from sales where order_id>'" + 1 + "'";
                    //SqlCommand com5 = new SqlCommand(q5, con5);
                    //com5.ExecuteNonQuery();
                    //con5.Close();
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    con.Open();
                    string q = "delete from products where P_name='" + textBox1.Text + "'";
                    SqlCommand com = new SqlCommand(q, con);
                    com.ExecuteNonQuery();
                    con.Close();
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string query = "insert into products values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "')";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("item successfully updated");
                    this.Hide();
                    manager_window m = new manager_window();
                    m.Show();
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("invalid entries");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                co.Open();
                string q1="select P_name from products where P_name='"+textBox5.Text+"'";
                SqlCommand c = new SqlCommand(q1, co);
                SqlDataReader rd = c.ExecuteReader();
                if (rd.HasRows == true)
                {
                    co.Close();
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    con.Open();
                    //DateTime dateTime = DateTime.UtcNow.Date;
                    string query = "select P_name,P_price,P_quantity,P_category,P_stock from products where P_name='" + textBox5.Text + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    textBox1.Text = dt.Rows[0][0].ToString();
                    textBox2.Text = dt.Rows[0][1].ToString();
                    textBox3.Text = dt.Rows[0][2].ToString();
                    textBox4.Text = dt.Rows[0][3].ToString();
                    textBox6.Text = dt.Rows[0][4].ToString();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox6.Visible = true;
                    button1.Visible = true;
                    button2.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label6.Visible = true;
                    label4.Visible = true;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("this item not exist ");
                }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }
    }
}
