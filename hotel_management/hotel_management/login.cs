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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
            conn.Open();       
            string query = "select status from user_account where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader rd = comm.ExecuteReader();
            if(rd.HasRows==true)
            {
                rd.Read();
                if (textBox1.Text=="ali123")
                {
                    this.Hide();
                    manager_window m=new manager_window();
                    m.Show();
                    conn.Close();
                }
                //else if (rd["status"].ToString() == "cashier")
                //else if (textBox1.Text.ToString() == "amir321")
                else
                {
                    this.Hide();
                    PBill m = new PBill();
                    m.Show();
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("wrong id or password");
                this.Hide();
                login l = new login();
                l.Show();
                conn.Close();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            change_pass p = new change_pass();
            p.Show();

        }
    }
}
