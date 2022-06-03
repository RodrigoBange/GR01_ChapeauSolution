namespace GR01_ChapeauSolution
{
    partial class Login
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
            this.imgLogin_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtBox_Login_Password = new System.Windows.Forms.TextBox();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.lbl_Login_EmployeeID = new System.Windows.Forms.Label();
            this.txtBox_Login_EmployeeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin_Logo)).BeginInit();
            this.pnl_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(660, 67);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Login";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgLogin_Logo
            // 
            this.imgLogin_Logo.BackgroundImage = global::ChapeauUI.Properties.Resources.Logo;
            this.imgLogin_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogin_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogin_Logo.Location = new System.Drawing.Point(0, 67);
            this.imgLogin_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.imgLogin_Logo.Name = "imgLogin_Logo";
            this.imgLogin_Logo.Size = new System.Drawing.Size(660, 229);
            this.imgLogin_Logo.TabIndex = 3;
            this.imgLogin_Logo.TabStop = false;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Controls.Add(this.txtBox_Login_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login_EmployeeID);
            this.pnl_Login.Controls.Add(this.txtBox_Login_EmployeeID);
            this.pnl_Login.Location = new System.Drawing.Point(61, 337);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(538, 439);
            this.pnl_Login.TabIndex = 4;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(186, 193);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(167, 53);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtBox_Login_Password
            // 
            this.txtBox_Login_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.txtBox_Login_Password.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Login_Password.ForeColor = System.Drawing.Color.White;
            this.txtBox_Login_Password.Location = new System.Drawing.Point(184, 126);
            this.txtBox_Login_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Login_Password.Name = "txtBox_Login_Password";
            this.txtBox_Login_Password.PasswordChar = '●';
            this.txtBox_Login_Password.PlaceholderText = "Enter your password";
            this.txtBox_Login_Password.Size = new System.Drawing.Size(327, 40);
            this.txtBox_Login_Password.TabIndex = 4;
            this.txtBox_Login_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_Password.ForeColor = System.Drawing.Color.White;
            this.lbl_Login_Password.Location = new System.Drawing.Point(14, 128);
            this.lbl_Login_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(138, 33);
            this.lbl_Login_Password.TabIndex = 3;
            this.lbl_Login_Password.Text = "Password : ";
            // 
            // lbl_Login_EmployeeID
            // 
            this.lbl_Login_EmployeeID.AutoSize = true;
            this.lbl_Login_EmployeeID.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_EmployeeID.ForeColor = System.Drawing.Color.White;
            this.lbl_Login_EmployeeID.Location = new System.Drawing.Point(13, 72);
            this.lbl_Login_EmployeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Login_EmployeeID.Name = "lbl_Login_EmployeeID";
            this.lbl_Login_EmployeeID.Size = new System.Drawing.Size(171, 33);
            this.lbl_Login_EmployeeID.TabIndex = 2;
            this.lbl_Login_EmployeeID.Text = "Employee ID : ";
            // 
            // txtBox_Login_EmployeeID
            // 
            this.txtBox_Login_EmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.txtBox_Login_EmployeeID.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Login_EmployeeID.ForeColor = System.Drawing.Color.White;
            this.txtBox_Login_EmployeeID.Location = new System.Drawing.Point(184, 66);
            this.txtBox_Login_EmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Login_EmployeeID.Name = "txtBox_Login_EmployeeID";
            this.txtBox_Login_EmployeeID.PlaceholderText = "Enter your employee ID";
            this.txtBox_Login_EmployeeID.Size = new System.Drawing.Size(327, 40);
            this.txtBox_Login_EmployeeID.TabIndex = 1;
            this.txtBox_Login_EmployeeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Login_EmployeeID_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(660, 879);
            this.Controls.Add(this.pnl_Login);
            this.Controls.Add(this.imgLogin_Logo);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin_Logo)).EndInit();
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox imgLogin_Logo;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.TextBox txtBox_Login_Password;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.Label lbl_Login_EmployeeID;
        private System.Windows.Forms.TextBox txtBox_Login_EmployeeID;
        private System.Windows.Forms.Button btn_Login;
    }
}