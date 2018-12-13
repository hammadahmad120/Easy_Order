using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management
{
    public partial class manager_window : Form
    {
        public manager_window()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void todaysSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            sale s=new sale();
            s.Show();
        }

        private void customSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            custom_sale c = new custom_sale();
            c.Show();
        }

        private void foodReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            report r = new report();
            r.Show();
        }

        private void serviceReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            report r = new report();
            r.Show();
        }

        private void customFoodReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            bad_review r = new bad_review();
            r.Show();
        }

        private void addNewFoodItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            item r = new item();
            r.Show();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delitem r = new Delitem();
            r.Show();
        }

        private void modifyItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify f = new Modify();
            f.Show();
        }

        private void viewFoodItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            food_list f = new food_list();
            f.Show();
        }

        private void createNewLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new_login l = new new_login();
            l.Show();
        }

        private void viewCashiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_cashiers c = new view_cashiers();
            c.Show();
        }

        private void removeCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            remove_cashier c = new remove_cashier();
            c.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void viewShortItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            view_shortage v = new view_shortage();
            v.Show();
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            change_pass p = new change_pass();
            p.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manager_window_Load(object sender, EventArgs e)
        {

        }

        private void rangeBetweenSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            select_sale c = new select_sale();
            c.Show();
        }
    }
}
