namespace hotel_management
{
    partial class manager_window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCashiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFoodItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFoodItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShortItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaysSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangeBetweenSaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foodReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customFoodReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(-1, 160);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 54);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // loginsToolStripMenuItem
            // 
            this.loginsToolStripMenuItem.AutoSize = false;
            this.loginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewLoginToolStripMenuItem,
            this.removeCashierToolStripMenuItem,
            this.viewCashiersToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.loginsToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.loginsToolStripMenuItem.Name = "loginsToolStripMenuItem";
            this.loginsToolStripMenuItem.Size = new System.Drawing.Size(350, 50);
            this.loginsToolStripMenuItem.Text = "Logins";
            // 
            // createNewLoginToolStripMenuItem
            // 
            this.createNewLoginToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.createNewLoginToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.createNewLoginToolStripMenuItem.Name = "createNewLoginToolStripMenuItem";
            this.createNewLoginToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.createNewLoginToolStripMenuItem.Text = "create new login";
            this.createNewLoginToolStripMenuItem.Click += new System.EventHandler(this.createNewLoginToolStripMenuItem_Click);
            // 
            // removeCashierToolStripMenuItem
            // 
            this.removeCashierToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.removeCashierToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.removeCashierToolStripMenuItem.Name = "removeCashierToolStripMenuItem";
            this.removeCashierToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.removeCashierToolStripMenuItem.Text = "Remove cashier";
            this.removeCashierToolStripMenuItem.Click += new System.EventHandler(this.removeCashierToolStripMenuItem_Click);
            // 
            // viewCashiersToolStripMenuItem
            // 
            this.viewCashiersToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.viewCashiersToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.viewCashiersToolStripMenuItem.Name = "viewCashiersToolStripMenuItem";
            this.viewCashiersToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.viewCashiersToolStripMenuItem.Text = "View Cashiers";
            this.viewCashiersToolStripMenuItem.Click += new System.EventHandler(this.viewCashiersToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(303, 36);
            this.changePasswordToolStripMenuItem.Text = "change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.AutoSize = false;
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFoodItemToolStripMenuItem,
            this.deleteItemToolStripMenuItem,
            this.modifyItemToolStripMenuItem,
            this.viewFoodItemsToolStripMenuItem,
            this.viewShortItemsToolStripMenuItem});
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(350, 50);
            this.updateToolStripMenuItem.Text = " Update and view";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // addNewFoodItemToolStripMenuItem
            // 
            this.addNewFoodItemToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.addNewFoodItemToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.addNewFoodItemToolStripMenuItem.Name = "addNewFoodItemToolStripMenuItem";
            this.addNewFoodItemToolStripMenuItem.Size = new System.Drawing.Size(330, 36);
            this.addNewFoodItemToolStripMenuItem.Text = "Add New Food Item";
            this.addNewFoodItemToolStripMenuItem.Click += new System.EventHandler(this.addNewFoodItemToolStripMenuItem_Click);
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.deleteItemToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(330, 36);
            this.deleteItemToolStripMenuItem.Text = "Delete Food Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // modifyItemToolStripMenuItem
            // 
            this.modifyItemToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.modifyItemToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.modifyItemToolStripMenuItem.Name = "modifyItemToolStripMenuItem";
            this.modifyItemToolStripMenuItem.Size = new System.Drawing.Size(330, 36);
            this.modifyItemToolStripMenuItem.Text = "Modify Item";
            this.modifyItemToolStripMenuItem.Click += new System.EventHandler(this.modifyItemToolStripMenuItem_Click);
            // 
            // viewFoodItemsToolStripMenuItem
            // 
            this.viewFoodItemsToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.viewFoodItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.viewFoodItemsToolStripMenuItem.Name = "viewFoodItemsToolStripMenuItem";
            this.viewFoodItemsToolStripMenuItem.Size = new System.Drawing.Size(330, 36);
            this.viewFoodItemsToolStripMenuItem.Text = "View Food Items";
            this.viewFoodItemsToolStripMenuItem.Click += new System.EventHandler(this.viewFoodItemsToolStripMenuItem_Click);
            // 
            // viewShortItemsToolStripMenuItem
            // 
            this.viewShortItemsToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.viewShortItemsToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.viewShortItemsToolStripMenuItem.Name = "viewShortItemsToolStripMenuItem";
            this.viewShortItemsToolStripMenuItem.Size = new System.Drawing.Size(330, 36);
            this.viewShortItemsToolStripMenuItem.Text = "View Short Items";
            this.viewShortItemsToolStripMenuItem.Click += new System.EventHandler(this.viewShortItemsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.AutoSize = false;
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.Chocolate;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesToolStripMenuItem,
            this.reviewsToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(350, 50);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todaysSaleToolStripMenuItem,
            this.customSaleToolStripMenuItem,
            this.rangeBetweenSaleToolStripMenuItem});
            this.salesToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // todaysSaleToolStripMenuItem
            // 
            this.todaysSaleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.todaysSaleToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.todaysSaleToolStripMenuItem.Name = "todaysSaleToolStripMenuItem";
            this.todaysSaleToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.todaysSaleToolStripMenuItem.Text = "today\'s Sale";
            this.todaysSaleToolStripMenuItem.Click += new System.EventHandler(this.todaysSaleToolStripMenuItem_Click);
            // 
            // customSaleToolStripMenuItem
            // 
            this.customSaleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.customSaleToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.customSaleToolStripMenuItem.Name = "customSaleToolStripMenuItem";
            this.customSaleToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.customSaleToolStripMenuItem.Text = "Custom Sale";
            this.customSaleToolStripMenuItem.Click += new System.EventHandler(this.customSaleToolStripMenuItem_Click);
            // 
            // rangeBetweenSaleToolStripMenuItem
            // 
            this.rangeBetweenSaleToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.rangeBetweenSaleToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.rangeBetweenSaleToolStripMenuItem.Name = "rangeBetweenSaleToolStripMenuItem";
            this.rangeBetweenSaleToolStripMenuItem.Size = new System.Drawing.Size(327, 36);
            this.rangeBetweenSaleToolStripMenuItem.Text = "sale between range";
            this.rangeBetweenSaleToolStripMenuItem.Click += new System.EventHandler(this.rangeBetweenSaleToolStripMenuItem_Click);
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.reviewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foodReviewToolStripMenuItem,
            this.serviceReviewToolStripMenuItem,
            this.customFoodReviewToolStripMenuItem});
            this.reviewsToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            // 
            // foodReviewToolStripMenuItem
            // 
            this.foodReviewToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.foodReviewToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.foodReviewToolStripMenuItem.Name = "foodReviewToolStripMenuItem";
            this.foodReviewToolStripMenuItem.Size = new System.Drawing.Size(340, 36);
            this.foodReviewToolStripMenuItem.Text = "Food review";
            this.foodReviewToolStripMenuItem.Click += new System.EventHandler(this.foodReviewToolStripMenuItem_Click);
            // 
            // serviceReviewToolStripMenuItem
            // 
            this.serviceReviewToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.serviceReviewToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.serviceReviewToolStripMenuItem.Name = "serviceReviewToolStripMenuItem";
            this.serviceReviewToolStripMenuItem.Size = new System.Drawing.Size(340, 36);
            this.serviceReviewToolStripMenuItem.Text = "Service Review";
            this.serviceReviewToolStripMenuItem.Click += new System.EventHandler(this.serviceReviewToolStripMenuItem_Click);
            // 
            // customFoodReviewToolStripMenuItem
            // 
            this.customFoodReviewToolStripMenuItem.BackColor = System.Drawing.Color.Khaki;
            this.customFoodReviewToolStripMenuItem.ForeColor = System.Drawing.Color.Chocolate;
            this.customFoodReviewToolStripMenuItem.Name = "customFoodReviewToolStripMenuItem";
            this.customFoodReviewToolStripMenuItem.Size = new System.Drawing.Size(340, 36);
            this.customFoodReviewToolStripMenuItem.Text = "Custom food Review";
            this.customFoodReviewToolStripMenuItem.Click += new System.EventHandler(this.customFoodReviewToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 158);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(809, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Foodies For Life";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Georgia", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(347, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "EASY ORDER";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(1242, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOG OUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "manager_window";
            this.Load += new System.EventHandler(this.manager_window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCashiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFoodItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFoodItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaysSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customSaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foodReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceReviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customFoodReviewToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem viewShortItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangeBetweenSaleToolStripMenuItem;
    }
}