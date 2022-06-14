namespace ChapeauUI.Forms
{
    partial class MessageBox_OccupiedTakeorder
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_MarkAsOccupied = new System.Windows.Forms.Button();
            this.btn_TakeOrder = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(1, 1);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.MaximumSize = new System.Drawing.Size(498, 46);
            this.lbl_Title.MinimumSize = new System.Drawing.Size(498, 46);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lbl_Title.Size = new System.Drawing.Size(498, 46);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.flowLayoutPanel1.Controls.Add(this.lbl_Message);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 47);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(498, 94);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // lbl_Message
            // 
            this.lbl_Message.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Message.Location = new System.Drawing.Point(0, 0);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Message.MaximumSize = new System.Drawing.Size(500, 0);
            this.lbl_Message.MinimumSize = new System.Drawing.Size(500, 92);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbl_Message.Size = new System.Drawing.Size(500, 92);
            this.lbl_Message.TabIndex = 4;
            this.lbl_Message.Text = "This table is empty";
            this.lbl_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Message.UseCompatibleTextRendering = true;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_Buttons.Controls.Add(this.btn_MarkAsOccupied);
            this.pnl_Buttons.Controls.Add(this.btn_TakeOrder);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Buttons.Location = new System.Drawing.Point(1, 141);
            this.pnl_Buttons.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(498, 137);
            this.pnl_Buttons.TabIndex = 6;
            // 
            // btn_MarkAsOccupied
            // 
            this.btn_MarkAsOccupied.AutoSize = true;
            this.btn_MarkAsOccupied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_MarkAsOccupied.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_MarkAsOccupied.FlatAppearance.BorderSize = 2;
            this.btn_MarkAsOccupied.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarkAsOccupied.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MarkAsOccupied.Location = new System.Drawing.Point(103, 14);
            this.btn_MarkAsOccupied.Margin = new System.Windows.Forms.Padding(2);
            this.btn_MarkAsOccupied.Name = "btn_MarkAsOccupied";
            this.btn_MarkAsOccupied.Size = new System.Drawing.Size(291, 46);
            this.btn_MarkAsOccupied.TabIndex = 0;
            this.btn_MarkAsOccupied.Text = "Mark as occupied";
            this.btn_MarkAsOccupied.UseCompatibleTextRendering = true;
            this.btn_MarkAsOccupied.UseVisualStyleBackColor = false;
            this.btn_MarkAsOccupied.Click += new System.EventHandler(this.btn_MarkAsOccupied_Click);
            // 
            // btn_TakeOrder
            // 
            this.btn_TakeOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_TakeOrder.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_TakeOrder.FlatAppearance.BorderSize = 2;
            this.btn_TakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TakeOrder.Location = new System.Drawing.Point(103, 74);
            this.btn_TakeOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TakeOrder.Name = "btn_TakeOrder";
            this.btn_TakeOrder.Size = new System.Drawing.Size(290, 46);
            this.btn_TakeOrder.TabIndex = 1;
            this.btn_TakeOrder.Text = "Take order";
            this.btn_TakeOrder.UseCompatibleTextRendering = true;
            this.btn_TakeOrder.UseVisualStyleBackColor = false;
            this.btn_TakeOrder.Click += new System.EventHandler(this.btn_TakeOrder_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.btn_Exit.BackgroundImage = global::ChapeauUI.Properties.Resources.cross1;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Location = new System.Drawing.Point(448, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(39, 39);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MessageBox_OccupiedTakeorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 279);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Buttons);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 667);
            this.Name = "MessageBox_OccupiedTakeorder";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox_PopUp";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_MarkAsOccupied;
        private System.Windows.Forms.Button btn_TakeOrder;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_Exit;
    }
}