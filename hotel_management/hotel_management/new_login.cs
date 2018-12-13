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
    public partial class new_login : Form
    {
        public new_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && (textBox3.Text == "cashier"))
            {
                SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                co.Open();
                string q1 = "select username from user_account where username='" + textBox1.Text + "'";
                SqlCommand c = new SqlCommand(q1, co);
                SqlDataReader rd = c.ExecuteReader();
               
                if (rd.HasRows != true)
                {
                    co.Close();



                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string query = "insert into user_account values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("login created");
                    this.Hide();
                    manager_window m = new manager_window();
                    m.Show();
                    conn.Close();
                   
                }
                else
                {
                    MessageBox.Show("this username already exist");
                }

            }
            else
            {
                MessageBox.Show("invalid entries");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }
    }
}
