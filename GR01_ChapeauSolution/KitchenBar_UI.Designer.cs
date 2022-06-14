
namespace ChapeauUI
{
    partial class KitchenBar_UI
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Bar = new System.Windows.Forms.Panel();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.listView_Bar = new System.Windows.Forms.ListView();
            this.Checcck = new System.Windows.Forms.ColumnHeader();
            this.Order = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Drink_Name = new System.Windows.Forms.ColumnHeader();
            this.Ammount = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.pnl_Food = new System.Windows.Forms.Panel();
            this.pnl_Kitchen = new System.Windows.Forms.Panel();
            this.Dinner = new System.Windows.Forms.Button();
            this.Lunch = new System.Windows.Forms.Button();
            this.lbl_TitleKitchen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView_Food = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_Bar.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.pnl_Food.SuspendLayout();
            this.pnl_Kitchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Bar
            // 
            this.pnl_Bar.Controls.Add(this.pnl_Header);
            this.pnl_Bar.Controls.Add(this.listView_Bar);
            this.pnl_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bar.Name = "pnl_Bar";
            this.pnl_Bar.Size = new System.Drawing.Size(913, 638);
            this.pnl_Bar.TabIndex = 0;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnl_Header.Controls.Add(this.btn_Ready);
            this.pnl_Header.Controls.Add(this.label_Time);
            this.pnl_Header.Controls.Add(this.btn_User);
            this.pnl_Header.Controls.Add(this.lbl_TitleBar);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(913, 67);
            this.pnl_Header.TabIndex = 1;
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(35, 22);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(94, 29);
            this.btn_Ready.TabIndex = 3;
            this.btn_Ready.Text = "Ready";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(782, 28);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(0, 20);
            this.label_Time.TabIndex = 1;
            // 
            // btn_User
            // 
            this.btn_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_User.BackgroundImage = global::ChapeauUI.Properties.Resources.User_Icon;
            this.btn_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_User.FlatAppearance.BorderSize = 0;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Location = new System.Drawing.Point(847, 11);
            this.btn_User.Margin = new System.Windows.Forms.Padding(2);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(50, 50);
            this.btn_User.TabIndex = 0;
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Visible = false;
            // 
            // lbl_TitleBar
            // 
            this.lbl_TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TitleBar.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.lbl_TitleBar.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TitleBar.Name = "lbl_TitleBar";
            this.lbl_TitleBar.Size = new System.Drawing.Size(913, 67);
            this.lbl_TitleBar.TabIndex = 1;
            this.lbl_TitleBar.Text = "Bar View";
            this.lbl_TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_Bar
            // 
            this.listView_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.listView_Bar.CheckBoxes = true;
            this.listView_Bar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Checcck,
            this.Order,
            this.Type,
            this.Drink_Name,
            this.Ammount,
            this.Comment,
            this.Time});
            this.listView_Bar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_Bar.HideSelection = false;
            this.listView_Bar.Location = new System.Drawing.Point(12, 81);
            this.listView_Bar.Name = "listView_Bar";
            this.listView_Bar.Size = new System.Drawing.Size(883, 538);
            this.listView_Bar.TabIndex = 2;
            this.listView_Bar.UseCompatibleStateImageBehavior = false;
            this.listView_Bar.View = System.Windows.Forms.View.Details;
            this.listView_Bar.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Checcck
            // 
            this.Checcck.Text = "Status";
            // 
            // Order
            // 
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 180;
            // 
            // Drink_Name
            // 
            this.Drink_Name.Text = "Drink Name";
            this.Drink_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Drink_Name.Width = 140;
            // 
            // Ammount
            // 
            this.Ammount.Text = "Ammount";
            this.Ammount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ammount.Width = 130;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Comment.Width = 180;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Time.Width = 130;
            // 
            // pnl_Food
            // 
            this.pnl_Food.Controls.Add(this.pnl_Kitchen);
            this.pnl_Food.Controls.Add(this.listView_Food);
            this.pnl_Food.Location = new System.Drawing.Point(-2, -4);
            this.pnl_Food.Name = "pnl_Food";
            this.pnl_Food.Size = new System.Drawing.Size(913, 638);
            this.pnl_Food.TabIndex = 1;
            // 
            // pnl_Kitchen
            // 
            this.pnl_Kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnl_Kitchen.Controls.Add(this.Dinner);
            this.pnl_Kitchen.Controls.Add(this.Lunch);
            this.pnl_Kitchen.Controls.Add(this.lbl_TitleKitchen);
            this.pnl_Kitchen.Controls.Add(this.label1);
            this.pnl_Kitchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Kitchen.Location = new System.Drawing.Point(0, 0);
            this.pnl_Kitchen.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Kitchen.Name = "pnl_Kitchen";
            this.pnl_Kitchen.Size = new System.Drawing.Size(913, 67);
            this.pnl_Kitchen.TabIndex = 1;
            // 
            // Dinner
            // 
            this.Dinner.Location = new System.Drawing.Point(114, 32);
            this.Dinner.Name = "Dinner";
            this.Dinner.Size = new System.Drawing.Size(94, 29);
            this.Dinner.TabIndex = 6;
            this.Dinner.Text = "Dinner";
            this.Dinner.UseVisualStyleBackColor = true;
            this.Dinner.Click += new System.EventHandler(this.Dinner_Click);
            // 
            // Lunch
            // 
            this.Lunch.Location = new System.Drawing.Point(14, 32);
            this.Lunch.Name = "Lunch";
            this.Lunch.Size = new System.Drawing.Size(94, 29);
            this.Lunch.TabIndex = 5;
            this.Lunch.Text = "Lunch";
            this.Lunch.UseVisualStyleBackColor = true;
            this.Lunch.Click += new System.EventHandler(this.Lunch_Click);
            // 
            // lbl_TitleKitchen
            // 
            this.lbl_TitleKitchen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TitleKitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_TitleKitchen.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TitleKitchen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.lbl_TitleKitchen.Location = new System.Drawing.Point(0, 0);
            this.lbl_TitleKitchen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TitleKitchen.Name = "lbl_TitleKitchen";
            this.lbl_TitleKitchen.Size = new System.Drawing.Size(913, 67);
            this.lbl_TitleKitchen.TabIndex = 4;
            this.lbl_TitleKitchen.Text = "Kitchen View";
            this.lbl_TitleKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(782, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // listView_Food
            // 
            this.listView_Food.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.listView_Food.CheckBoxes = true;
            this.listView_Food.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Food.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView_Food.HideSelection = false;
            this.listView_Food.Location = new System.Drawing.Point(12, 81);
            this.listView_Food.Name = "listView_Food";
            this.listView_Food.Size = new System.Drawing.Size(883, 538);
            this.listView_Food.TabIndex = 2;
            this.listView_Food.UseCompatibleStateImageBehavior = false;
            this.listView_Food.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Status";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Drink Name";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ammount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Comment";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 180;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Time";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 130;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            // 
            // KitchenBar_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(908, 631);
            this.Controls.Add(this.pnl_Food);
            this.Controls.Add(this.pnl_Bar);
            this.Name = "KitchenBar_UI";
            this.Text = "Form1";
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Food.ResumeLayout(false);
            this.pnl_Kitchen.ResumeLayout(false);
            this.pnl_Kitchen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Bar;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Label lbl_TitleBar;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Drink_Name;
        private System.Windows.Forms.ColumnHeader Ammount;
        private System.Windows.Forms.ListView listView_Bar;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ColumnHeader Checcck;
        private System.Windows.Forms.ColumnHeader Order;
        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Panel pnl_Food;
        private System.Windows.Forms.Panel pnl_Kitchen;
        private System.Windows.Forms.Label lbl_TitleKitchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_Food;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button Dinner;
        private System.Windows.Forms.Button Lunch;
        private System.Windows.Forms.Timer timer;
    }
}