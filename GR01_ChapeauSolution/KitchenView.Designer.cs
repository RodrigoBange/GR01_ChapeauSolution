
namespace ChapeauUI
{
    partial class KitchenView
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnl_Header.Controls.Add(this.btn_Return);
            this.pnl_Header.Controls.Add(this.btn_User);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(907, 67);
            this.pnl_Header.TabIndex = 1;
            // 
            // btn_Return
            // 
            this.btn_Return.BackgroundImage = global::ChapeauUI.Properties.Resources.Home_Icon_New1;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Return.Location = new System.Drawing.Point(2, 0);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(92, 67);
            this.btn_Return.TabIndex = 4;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Visible = false;
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
            this.btn_User.Location = new System.Drawing.Point(846, 11);
            this.btn_User.Margin = new System.Windows.Forms.Padding(2);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(50, 50);
            this.btn_User.TabIndex = 0;
            this.btn_User.UseVisualStyleBackColor = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(907, 67);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Kitchen View";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KitchenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(907, 630);
            this.Controls.Add(this.pnl_Header);
            this.MaximumSize = new System.Drawing.Size(933, 677);
            this.MinimumSize = new System.Drawing.Size(855, 677);
            this.Name = "KitchenView";
            this.Text = "Form1";
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Label lbl_Title;
    }
}