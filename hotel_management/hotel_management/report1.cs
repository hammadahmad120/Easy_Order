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
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime date = dateTimePicker1.Value;
            DateTime date1 = dateTimePicker2.Value;
            if (date == date1||date<date1)
            {
                string from = date.ToString("M/d/yyyy");
                string to = date1.ToString("M/d/yyyy");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con.Open();
                //DateTime dateTime = DateTime.UtcNow.Date;
                string query = "select service,count(service) from food_review where date between'" + from + "' and '" + to + "' group by service ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    ListViewItem lst = new ListViewItem(dt.Rows[i][0].ToString());
                    lst.SubItems.Add(dt.Rows[i][1].ToString());
                    listView1.Items.Add(lst);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("fromDate cannot be greater then toDate");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }

        private void report1_Load(object sender, EventArgs e)
        {

        }
    }
}
