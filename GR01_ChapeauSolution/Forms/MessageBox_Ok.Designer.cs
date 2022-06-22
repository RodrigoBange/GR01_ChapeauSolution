namespace ChapeauUI.Forms
{
    partial class MessageBox_Ok
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
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(1, 1);
            this.lbl_Title.MaximumSize = new System.Drawing.Size(598, 55);
            this.lbl_Title.MinimumSize = new System.Drawing.Size(598, 55);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_Title.Size = new System.Drawing.Size(598, 55);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.lbl_Message.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Message.Location = new System.Drawing.Point(1, 56);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Message.MaximumSize = new System.Drawing.Size(598, 0);
            this.lbl_Message.MinimumSize = new System.Drawing.Size(598, 113);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_Message.Size = new System.Drawing.Size(598, 113);
            this.lbl_Message.TabIndex = 3;
            this.lbl_Message.Text = "Message text";
            this.lbl_Message.UseCompatibleTextRendering = true;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_Buttons.Controls.Add(this.btn_Ok);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Buttons.Location = new System.Drawing.Point(1, 169);
            this.pnl_Buttons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(598, 80);
            this.pnl_Buttons.TabIndex = 6;
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Ok.FlatAppearance.BorderSize = 2;
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ok.Location = new System.Drawing.Point(234, 12);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(150, 50);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseCompatibleTextRendering = true;
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // MessageBox_Ok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.lbl_Title);
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "MessageBox_Ok";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox_Warning";
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Ok;
    }
}