
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
            this.label_Time = new System.Windows.Forms.Label();
            this.btn_User = new System.Windows.Forms.Button();
            this.lbl_TitleKitchen = new System.Windows.Forms.Label();
            this.lbl_TitleBar = new System.Windows.Forms.Label();
            this.listView_Bar = new System.Windows.Forms.ListView();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.Drink_Name = new System.Windows.Forms.ColumnHeader();
            this.Ammount = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.Time = new System.Windows.Forms.ColumnHeader();
            this.Checcck = new System.Windows.Forms.ColumnHeader();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Order = new System.Windows.Forms.ColumnHeader();
            this.pnl_Bar.SuspendLayout();
            this.pnl_Header.SuspendLayout();
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
            this.pnl_Header.Controls.Add(this.label_Time);
            this.pnl_Header.Controls.Add(this.btn_User);
            this.pnl_Header.Controls.Add(this.lbl_TitleKitchen);
            this.pnl_Header.Controls.Add(this.lbl_TitleBar);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(913, 67);
            this.pnl_Header.TabIndex = 1;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(13, 28);
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
            this.lbl_TitleKitchen.TabIndex = 2;
            this.lbl_TitleKitchen.Text = "Kitchen View";
            this.lbl_TitleKitchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Checcck
            // 
            this.Checcck.Text = "Status";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // Order
            // 
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KitchenBar_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(908, 631);
            this.Controls.Add(this.pnl_Bar);
            this.Name = "KitchenBar_UI";
            this.Text = "Form1";
            this.pnl_Bar.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
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
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_TitleKitchen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ColumnHeader Checcck;
        private System.Windows.Forms.ColumnHeader Order;
    }
}