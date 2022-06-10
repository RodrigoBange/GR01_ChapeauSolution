namespace ChapeauUI.Forms
{
    partial class MessageBox_YesNo
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
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.btn_Decline = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Buttons.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.lbl_Question.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Question.Location = new System.Drawing.Point(1, 279);
            this.lbl_Question.MaximumSize = new System.Drawing.Size(598, 0);
            this.lbl_Question.MinimumSize = new System.Drawing.Size(598, 40);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(598, 40);
            this.lbl_Question.TabIndex = 4;
            this.lbl_Question.Text = "Question or finishing text";
            this.lbl_Question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(0, 0);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.lbl_Message.MaximumSize = new System.Drawing.Size(600, 0);
            this.lbl_Message.MinimumSize = new System.Drawing.Size(600, 15);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.lbl_Message.Size = new System.Drawing.Size(600, 40);
            this.lbl_Message.TabIndex = 3;
            this.lbl_Message.Text = "Message text";
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_Buttons.Controls.Add(this.btn_Accept);
            this.pnl_Buttons.Controls.Add(this.btn_Decline);
            this.pnl_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Buttons.Location = new System.Drawing.Point(1, 319);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(598, 80);
            this.pnl_Buttons.TabIndex = 5;
            // 
            // btn_Accept
            // 
            this.btn_Accept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Accept.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Accept.FlatAppearance.BorderSize = 2;
            this.btn_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accept.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Accept.Location = new System.Drawing.Point(83, 12);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(150, 50);
            this.btn_Accept.TabIndex = 0;
            this.btn_Accept.Text = "Yes";
            this.btn_Accept.UseCompatibleTextRendering = true;
            this.btn_Accept.UseVisualStyleBackColor = false;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // btn_Decline
            // 
            this.btn_Decline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Decline.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Decline.FlatAppearance.BorderSize = 2;
            this.btn_Decline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Decline.Location = new System.Drawing.Point(365, 12);
            this.btn_Decline.Name = "btn_Decline";
            this.btn_Decline.Size = new System.Drawing.Size(150, 50);
            this.btn_Decline.TabIndex = 1;
            this.btn_Decline.Text = "No";
            this.btn_Decline.UseCompatibleTextRendering = true;
            this.btn_Decline.UseVisualStyleBackColor = false;
            this.btn_Decline.Click += new System.EventHandler(this.btn_Decline_Click);
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
            this.lbl_Title.TabIndex = 2;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 56);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(598, 223);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // MessageBox_YesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.pnl_Buttons);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.Name = "MessageBox_YesNo";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MessageBox_PopUp";
            this.pnl_Buttons.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Decline;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}