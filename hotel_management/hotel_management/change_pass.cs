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
    public partial class change_pass : Form
    {
        public change_pass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con.Open();
                //DateTime dateTime = DateTime.UtcNow.Date;
                string query = "select Password from user_account where username='" + textBox1.Text + "' and password='" + textBox2.Text + "' ";
                
                SqlCommand c = new SqlCommand(query, con);
                SqlDataReader rd = c.ExecuteReader();
                if (rd.HasRows == true)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string q = "update user_account set password='" + textBox3.Text + "' where username='" + textBox1.Text + "'";
                    SqlCommand com = new SqlCommand(q, conn);
                    com.ExecuteNonQuery();
                    this.Hide();
                    MessageBox.Show("Password Changed");
                    login m = new login();
                    m.Show();
                    conn.Close();
                    con.Close();

                }
                else
                {
                    MessageBox.Show("username or old password is wrong");
                }
            }
            else
            {
                MessageBox.Show("fields not completely filled");
            }
                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }
    }
}
