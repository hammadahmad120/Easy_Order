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
    public partial class select_sale : Form
    {
        public select_sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sale s = new sale();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            manager m=new manager();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            custom_sale s = new custom_sale();
            s.Show();
        }

        private void select_sale_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime date = dateTimePicker1.Value;
            DateTime date1 = dateTimePicker2.Value;
            string str1 = textBox3.Text.ToString();

            bool flag1 = false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] < '0' || str1[i] > '9')
                    flag1 = true;
            }
            string str2 = textBox4.Text.ToString();

            bool flag = false;
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] < '0' || str2[i] > '9')
                    flag = true;
            }

            if (date > date1)
            {
                MessageBox.Show("fromDate should be less then toDate");
            }
            else if (textBox3.Text == "" || textBox4.Text == "" || flag1 == true || flag == true || int.Parse(textBox3.Text) > int.Parse(textBox4.Text))
            {
                MessageBox.Show("invalid range entry");
            }
            else
            {
                int Rfrom = int.Parse(textBox3.Text);
                int Rto = int.Parse(textBox4.Text);
                string from = date.ToString("M/d/yyyy");
                string to = date1.ToString("M/d/yyyy");
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                con.Open();
                //DateTime dateTime = DateTime.UtcNow.Date;
                string query = "select sales.product,sum(sales.quantity),sum(sales.S_payment) from sales  inner join cc_order on sales.order_id=cc_order.order_id and date between'" + from + "' and '" + to + "' group by sales.product having sum(sales.quantity) between '" + Rfrom + "' and '" + Rto + "' ";
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
                int gtotal = 0, tx = 0;
                foreach (ListViewItem lstItem in listView1.Items)
                {
                    gtotal += int.Parse(lstItem.SubItems[2].Text);
                }
                tx = 16 * (gtotal / 100);
                gtotal = gtotal + tx;
                textBox1.Text = Convert.ToString(gtotal);
                textBox2.Text = Convert.ToString(tx);
                con.Close();
                textBox1.Visible = true;
                textBox2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            manager_window m = new manager_window();
            m.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
