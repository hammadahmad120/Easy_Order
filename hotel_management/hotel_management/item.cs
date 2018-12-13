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
    public partial class item : Form
    {
        public item()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = textBox2.Text.ToString();
            string str = textBox5.Text.ToString();
           
            bool flag1 = true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] < '0' || str1[i] > '9')
                    flag1 = false;
            }
            bool flag = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < '0' || str[i] > '9')
                    flag1 = false;
            }


            if (flag1 && flag && textBox1.Text != "" && comboBox2.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && Int32.Parse(textBox2.Text.ToString()) > 0 && Int32.Parse(textBox5.Text.ToString())>10)
            {
                SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                co.Open();
                string q1="select P_name from products where P_name='"+textBox1.Text+"'";
                SqlCommand c = new SqlCommand(q1, co);
                SqlDataReader rd = c.ExecuteReader();
                if (rd.HasRows != true)
                {
                    co.Close();



                    SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string query = "insert into products values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox2.Text + "','" + textBox5.Text + "')";
                    SqlCommand comm = new SqlCommand(query, conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("new food item successfully added");
                    this.Hide();
                    manager_window m = new manager_window();
                    m.Show();
                    conn.Close();
                    
                }
                else
                {
                    MessageBox.Show("this product already exist");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }
    }
}
