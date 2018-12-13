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
    public partial class review : Form
    {
        public review()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "insert into food_review(F_quality,service,phone,table_no) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox1.Text + "','"+3+"')";
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();

                MessageBox.Show("thanks for visiting and ur opinion");
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else
            {
                MessageBox.Show("combo boxes not completely filled");
                this.Hide();
                review r = new review();
                r.Show();
            }
        }
    }
}
