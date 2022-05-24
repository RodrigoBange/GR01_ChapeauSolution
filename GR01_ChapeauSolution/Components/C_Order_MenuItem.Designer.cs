namespace ChapeauUI.Components
{
    partial class C_Order_MenuItem
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
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_Main.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ItemName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ItemName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ItemName.MaximumSize = new System.Drawing.Size(372, 0);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lbl_ItemName.Size = new System.Drawing.Size(95, 57);
            this.lbl_ItemName.TabIndex = 0;
            this.lbl_ItemName.Text = "Steak";
            this.lbl_ItemName.UseCompatibleTextRendering = true;
            this.lbl_ItemName.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoSize = true;
            this.pnl_Main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Main.Controls.Add(this.lbl_ItemName);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(372, 62);
            this.pnl_Main.TabIndex = 3;
            this.pnl_Main.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(105)))), ((int)(((byte)(123)))));
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Enabled = false;
            this.splitter.Location = new System.Drawing.Point(15, 0);
            this.splitter.Margin = new System.Windows.Forms.Padding(0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(342, 3);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.splitter);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 62);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.pnl_Bottom.Size = new System.Drawing.Size(372, 3);
            this.pnl_Bottom.TabIndex = 3;
            // 
            // C_Order_MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Bottom);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(372, 0);
            this.MinimumSize = new System.Drawing.Size(372, 65);
            this.Name = "C_Order_MenuItem";
            this.Size = new System.Drawing.Size(372, 65);
            this.Click += new System.EventHandler(this.AddItem_Click);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel pnl_Bottom;
    }
}
