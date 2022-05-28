namespace ChapeauUI.Components
{
    partial class C_Order_OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.txtBox_Comment = new System.Windows.Forms.TextBox();
            this.pnl_ProductInfo = new System.Windows.Forms.Panel();
            this.pnl_ProductName = new System.Windows.Forms.Panel();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.pnl_ProductControls = new System.Windows.Forms.Panel();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_ProductTotalPrice = new System.Windows.Forms.Label();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnl_Main.SuspendLayout();
            this.pnl_ProductInfo.SuspendLayout();
            this.pnl_ProductName.SuspendLayout();
            this.pnl_ProductControls.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoSize = true;
            this.pnl_Main.Controls.Add(this.txtBox_Comment);
            this.pnl_Main.Controls.Add(this.pnl_ProductInfo);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_Main.ForeColor = System.Drawing.Color.White;
            this.pnl_Main.Location = new System.Drawing.Point(1, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(372, 122);
            this.pnl_Main.TabIndex = 0;
            // 
            // txtBox_Comment
            // 
            this.txtBox_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.txtBox_Comment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBox_Comment.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Comment.ForeColor = System.Drawing.Color.White;
            this.txtBox_Comment.Location = new System.Drawing.Point(0, 80);
            this.txtBox_Comment.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_Comment.MaxLength = 64;
            this.txtBox_Comment.Name = "txtBox_Comment";
            this.txtBox_Comment.PlaceholderText = "Comment...";
            this.txtBox_Comment.Size = new System.Drawing.Size(372, 42);
            this.txtBox_Comment.TabIndex = 0;
            this.txtBox_Comment.Leave += new System.EventHandler(this.AddComment);
            // 
            // pnl_ProductInfo
            // 
            this.pnl_ProductInfo.AutoSize = true;
            this.pnl_ProductInfo.Controls.Add(this.pnl_ProductName);
            this.pnl_ProductInfo.Controls.Add(this.pnl_ProductControls);
            this.pnl_ProductInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ProductInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_ProductInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ProductInfo.MinimumSize = new System.Drawing.Size(0, 80);
            this.pnl_ProductInfo.Name = "pnl_ProductInfo";
            this.pnl_ProductInfo.Size = new System.Drawing.Size(372, 80);
            this.pnl_ProductInfo.TabIndex = 6;
            // 
            // pnl_ProductName
            // 
            this.pnl_ProductName.AutoSize = true;
            this.pnl_ProductName.Controls.Add(this.lbl_ProductName);
            this.pnl_ProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ProductName.Location = new System.Drawing.Point(0, 0);
            this.pnl_ProductName.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ProductName.MinimumSize = new System.Drawing.Size(200, 0);
            this.pnl_ProductName.Name = "pnl_ProductName";
            this.pnl_ProductName.Size = new System.Drawing.Size(249, 35);
            this.pnl_ProductName.TabIndex = 6;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ProductName.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(137, 35);
            this.lbl_ProductName.TabIndex = 4;
            this.lbl_ProductName.Text = "Item name";
            // 
            // pnl_ProductControls
            // 
            this.pnl_ProductControls.AutoSize = true;
            this.pnl_ProductControls.Controls.Add(this.lbl_Count);
            this.pnl_ProductControls.Controls.Add(this.lbl_ProductTotalPrice);
            this.pnl_ProductControls.Controls.Add(this.btn_RemoveItem);
            this.pnl_ProductControls.Controls.Add(this.btn_AddItem);
            this.pnl_ProductControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ProductControls.Location = new System.Drawing.Point(249, 0);
            this.pnl_ProductControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ProductControls.Name = "pnl_ProductControls";
            this.pnl_ProductControls.Size = new System.Drawing.Size(123, 80);
            this.pnl_ProductControls.TabIndex = 5;
            // 
            // lbl_Count
            // 
            this.lbl_Count.Location = new System.Drawing.Point(38, 5);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(45, 38);
            this.lbl_Count.TabIndex = 3;
            this.lbl_Count.Text = "1";
            this.lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Count.UseCompatibleTextRendering = true;
            // 
            // lbl_ProductTotalPrice
            // 
            this.lbl_ProductTotalPrice.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProductTotalPrice.Location = new System.Drawing.Point(0, 40);
            this.lbl_ProductTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ProductTotalPrice.Name = "lbl_ProductTotalPrice";
            this.lbl_ProductTotalPrice.Size = new System.Drawing.Size(120, 35);
            this.lbl_ProductTotalPrice.TabIndex = 5;
            this.lbl_ProductTotalPrice.Text = "€ 0,00";
            this.lbl_ProductTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_RemoveItem.FlatAppearance.BorderSize = 0;
            this.btn_RemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveItem.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RemoveItem.Location = new System.Drawing.Point(85, 5);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(35, 35);
            this.btn_RemoveItem.TabIndex = 2;
            this.btn_RemoveItem.Text = "-";
            this.btn_RemoveItem.UseCompatibleTextRendering = true;
            this.btn_RemoveItem.UseVisualStyleBackColor = false;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddItem.FlatAppearance.BorderSize = 0;
            this.btn_AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddItem.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddItem.Location = new System.Drawing.Point(0, 5);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(35, 35);
            this.btn_AddItem.TabIndex = 1;
            this.btn_AddItem.Text = "+";
            this.btn_AddItem.UseCompatibleTextRendering = true;
            this.btn_AddItem.UseVisualStyleBackColor = false;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.splitter);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(1, 122);
            this.pnl_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(372, 15);
            this.pnl_Bottom.TabIndex = 0;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(105)))), ((int)(((byte)(123)))));
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Enabled = false;
            this.splitter.Location = new System.Drawing.Point(0, 12);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(372, 3);
            this.splitter.TabIndex = 0;
            this.splitter.TabStop = false;
            // 
            // C_Order_OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Bottom);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(373, 0);
            this.MinimumSize = new System.Drawing.Size(373, 137);
            this.Name = "C_Order_OrderItem";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Size = new System.Drawing.Size(373, 137);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_ProductInfo.ResumeLayout(false);
            this.pnl_ProductInfo.PerformLayout();
            this.pnl_ProductName.ResumeLayout(false);
            this.pnl_ProductName.PerformLayout();
            this.pnl_ProductControls.ResumeLayout(false);
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.TextBox txtBox_Comment;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_ProductTotalPrice;
        private System.Windows.Forms.Panel pnl_ProductControls;
        private System.Windows.Forms.Panel pnl_ProductName;
        private System.Windows.Forms.Panel pnl_ProductInfo;
    }
}
