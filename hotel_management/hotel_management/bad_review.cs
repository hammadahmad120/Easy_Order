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
    public partial class bad_review : Form
    {
        public bad_review()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime date = dateTimePicker1.Value;
            DateTime date1 = dateTimePicker2.Value;
            if (date > date1 || comboBox1.Text == "")
            {
                MessageBox.Show("invalid date entries or food quality");
            }
            else
            {
                string from = date.ToString("M/d/yyyy");
                string  to= date1.ToString("M/d/yyyy");
                listView1.Items.Clear();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con.Open();
                //DateTime dateTime = DateTime.UtcNow.Date;
                string query = "select sales.order_id,sales.product,food_review.phone  from sales  inner join food_review on sales.order_id=food_review.order_id and food_review.F_quality='" + comboBox1.Text + "' and date between '"+from+"' and '"+to+"' ";
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
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();

        }

    }
}
