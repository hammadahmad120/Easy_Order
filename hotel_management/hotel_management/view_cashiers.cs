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
    public partial class view_cashiers : Form
    {
        public view_cashiers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
            con.Open();
            string str = "cashier";
            //DateTime dateTime = DateTime.UtcNow.Date;
            string query = "select username,password,status,name,phone from user_account where status='" + str + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                ListViewItem lst = new ListViewItem(dt.Rows[i][0].ToString());
                lst.SubItems.Add(dt.Rows[i][1].ToString());
                lst.SubItems.Add(dt.Rows[i][2].ToString());
                lst.SubItems.Add(dt.Rows[i][3].ToString());
                lst.SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items.Add(lst);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }
    }
}
