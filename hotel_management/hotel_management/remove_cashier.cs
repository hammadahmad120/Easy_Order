﻿using System;
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
    public partial class remove_cashier : Form
    {
        public remove_cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                conn.Open();
                string query = "select username from user_account where username='" + textBox1.Text + "'";
                SqlCommand comm = new SqlCommand(query, conn);
                SqlDataReader rd = comm.ExecuteReader();
                if (rd.HasRows == true)
                {
                    conn.Close();
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\M. Hammad Shahid\Documents\Visual Studio 2013\Projects\hotel_management\hotel_management\Database1.mdf;Integrated Security=True");
                    conn.Open();
                    string q = "delete from user_account where username='" + textBox1.Text + "'";
                    SqlCommand com = new SqlCommand(q, conn);
                    com.ExecuteNonQuery();
                    
                    MessageBox.Show("login deleted");
                    this.Hide();
                    manager_window m = new manager_window();
                    m.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("no user exist with this username");

                }
            }
            else
            {
                MessageBox.Show("mention username");
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
